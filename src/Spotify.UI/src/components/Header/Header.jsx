import './header.scss'

import logo from '../../assets/icons/logo.svg';

const Header = () => {
    return (
        <header className='header'>
            <a href="#">
                <img className='header__logo' src={logo} alt="logo" />
            </a>
        </header>
    )
}

export default Header