import React from 'react'
import { Link } from 'react-router-dom'

//Style:
import { TopMenu, SpaceMenu } from './style.js'

export default function Menu(){
    return (
        <div>
            <TopMenu>
                <div className = "logo">
                    Logomarcar
                </div>
                <div>
                    <ul className = "nav">
                        <li>
                            <Link to = "/">Carro</Link>
                        </li>
                        <li>
                            <Link to = "/">Agendamentos</Link>
                            <ul>
                                <li>
                                    <Link to = "/">Agendar Teste Drive</Link>
                                </li>
                                <li>
                                    <Link to = "/ConsultarAgendamentos">Consultar Seus Agendamentos</Link>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>        
                <div className = "perfil">
                    Perfil
                </div>
            </TopMenu>
            <SpaceMenu />
        </div>
    )
}