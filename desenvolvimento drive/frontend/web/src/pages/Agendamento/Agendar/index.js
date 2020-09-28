import React, { useState } from 'react'

//Componets:
import Menu from '../../../components/Menu/index.js'

//Styles: 
import { ContainerInfo, StyledAgendar } from './styled.js'

/*Formatar data:
    https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat
*/

export default function Agendar(){
    const [ data, setData ] = useState(new Date().toISOString().substr(0, 10));
    const [ inicio, setInicio ] = useState("");
    const [ fim, setFim ] = useState("");
    const [ observacao, setObservacao ] = useState("");

    function Agendar(){
        const dados = {
            data,
            inicio,
            fim,
            observacao
        }

        console.log(dados);
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
                           onChange={(x) => setInicio(x.target.value)}
                        />
                    </div>
                    <div className="form-group">
                        <label>Horario de Fim:</label>
                        <input type="time" 
                          className="form-control" 
                        placeholder="Seu email" 
                        onChange={(x) => setFim(x.target.value)}
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