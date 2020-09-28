import React from 'react'
import { BrowserRouter, Switch, Route } from 'react-router-dom'

//Pages:
import Agendar from './pages/Agendamento/Agendar/index.js'

export default function Rotas(){
    return (
        <BrowserRouter>
            <Switch>
                <Route path = "/" component = { Agendar } />
            </Switch>
        </BrowserRouter>
    )
}