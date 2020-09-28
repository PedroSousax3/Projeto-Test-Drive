import React, { useState } from 'react'

//Components:
import Menu from '../../../components/Menu/index' 

//Styled:
import { MenuPage } from './styled'

export default function ConsultarAgendamentos(){
    const [ estado, setEstado ] = useState("pendente");

    const funcaoEstado = (nome) => {
        if (estado == nome)
            return true;
        else 
            return false; 
    }
    
    return (
        <div id = "consultarAgendamentos">
            <Menu />
            <MenuPage>
                <span onClick = {() => setEstado("pendente")}>Pendentes</span>
                <span onClick = {() => setEstado("comfirmadas")}>Comfirmadas</span>
                <span onClick = {() => setEstado("nao aceitas")}>Não Aceitas</span>
            </MenuPage>

            {
                funcaoEstado("pendente") && (
                    <div>Ok0</div>
                )
            }

            {
                funcaoEstado("comfirmadas") && (
                    <div>Ok1</div>
                )
            }

            {
                funcaoEstado("nao aceitas") && (
                    <div>Ok2</div>
                )
            }


        </div>
    );
}