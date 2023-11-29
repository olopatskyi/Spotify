import { motion } from 'framer-motion';

import Header from "../../components/Header/Header";

import '../../styles/login.scss';

const Login = () => {

    return (
        <>
            <Header/>

            <section className="login">
                <div className="login__wrapper">
                    <div className="login__block">
                        <div className="login__header">
                            <h1 className="login__title">
                                Увійти в Spotify
                            </h1>
                            <hr />
                        </div>

                        <form action="submit" className="login__form">

                            <label className="login__label" htmlFor="emailOrUsername">Ел. пошта або ім’я користувача:</label>
                            <input className="login__input" type="email" id="emailOrUsername" placeholder="Ел. пошта або ім’я користувача:" name="emailOrUsername" required/>

                            <label className="login__label psw" htmlFor="password">Пароль:</label>
                            <input className="login__input-psw" type="password" id="password" placeholder="Пароль:" name="password" required/>

                            <motion.button whileTap={{scale: 1.08}} className="login__btn" type="submit">
                                Увійти
                            </motion.button>
                        </form>

                        <hr />

                        <div className="login__footer">
                            <div className="login__footer-txt">
                                <span className="login__span">Немає акаунта?</span>
                                <a className="login__link" href="#">Зареєструватися в Spotify</a>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    )
}

export default Login