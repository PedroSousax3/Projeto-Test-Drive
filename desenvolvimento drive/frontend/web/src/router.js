import React from 'react'
import { BrowserRouter, Switch, Route } from 'react-router-dom'

//Pages:
import Agendar from './pages/Agendamento/Agendar/index';
import ConsultarAgendamentos from './pages/Agendamento/Consultar/index';

export default function Rotas(){
    return (
        <BrowserRouter>
            <Switch>
                <Route path = "/Agendar" component = { Agendar } />
                <Route path = "/ConsultarAgendamentos" component = { ConsultarAgendamentos } />
            </Switch>
        </BrowserRouter>
    )
}