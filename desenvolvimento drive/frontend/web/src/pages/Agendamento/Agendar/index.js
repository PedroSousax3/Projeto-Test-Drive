import React, { useState } from 'react'

//Componets:
import Menu from '../../../components/Menu/index.js'

//Styles: 
import { ContainerInfo, StyledAgendar } from './styled.js'

//Services:
import { CadastrarAgendamento } from '../../../services/agendar.js'
/*Formatar data:
    https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat
*/

export default function Agendar(){
    const [ data, setData ] = useState(new Date().toISOString().substr(0, 10));
    const [ inicio, setInicio ] = useState("");
    const [ fim, setFim ] = useState("");
    const [ observacao, setObservacao ] = useState("");

    function ConvertTime(time, funcao)
    {
        let hora = Number(time[0] + time[1]);
        let minuto =  Number(time[3] + time[4]);
        let result = new Date(1923,11,11, hora, minuto).toLocaleTimeString();

        funcao(result);
    }

    function Agendar(){
        const dados = {
            carro : 1,
            cliente : 1,
            data,
            inicio,
            fim,
            observacao
        }
        
        CadastrarAgendamento(dados);
        console.log("OK");
    }
    return (
        <StyledAgendar>
            <Menu />

            <ContainerInfo>
                <div className = "form">
                    <div className="form-group">
                        <label>Data de Agendamento:</label>
                        <input type="date" 
                          className="form-control" 
                             defaultValue = {data} 
                            onChange = {x => setData(new Date(x.target.value).toISOString().substr(0, 10))}
                        />
                    </div>
                    <div className="form-group">
                        <label>Horario de Inicio:</label>
                        <input type="time" 
                          className="form-control" 
                       defaultValue={inicio}
                           onChange={(x) => ConvertTime(x.target.value, setInicio)}
                        />
                    </div>
                    <div className="form-group">
                        <label>Horario de Fim:</label>
                        <input type="time" 
                          className="form-control" 
                        placeholder="Seu email" 
                        onChange={(x) => ConvertTime(x.target.value, setFim)}
                        />
                    </div>
                    <div className="form-group">
                        <label >Exemplo de textarea</label>
                        <textarea className="form-control" 
                                       rows="5" 
                                placeholder="Escreva uma observação para nossos funcionario."
                               defaultValue={observacao} 
                               onChange = {x => setObservacao(x.target.value)}
                        />
                    </div>
                    <button type="button" className="btn btn-success" onClick = {Agendar}>Agendar</button>
                </div>
            </ContainerInfo>
        </StyledAgendar>
    )
}