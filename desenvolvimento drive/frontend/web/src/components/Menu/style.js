import styled from 'styled-components'

export const TopMenu = styled.header`
    height: 60px;
    width: 100vw;
    background: var(--black-gradient);

    position: fixed;

    display: flex;
    justify-content: space-around;
    align-content: center;

    ul {
        list-style-type: none;
        padding: 0px;
    }

    .nav > li {
        float: left;
    }

    .nav li {
        padding: 10px 15px;
    }

    ul.nav > li > ul {
        display: none;
        position: absolute;


        background-color: white;
    }

    ul.nav > li:hover ul {
        display: block;
    }
`
export const SpaceMenu = styled.div`
    padding-bottom: 60px; 
`