<script>
    /**@type {Date}*/
    export let date;

    function move(last = true) {
        return () =>
            (date = new Date(
                date.getFullYear(),
                date.getMonth() + (last ? -1 : 1),
                1
            ));
    }
</script>

<header>
    <section>
        <button on:click={move(true)} title="Tháng trước">
            <svg
                aria-hidden="true"
                focusable="false"
                class="icon"
                role="img"
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 448 512"
                ><path
                    fill="currentColor"
                    d="M447.1 256C447.1 273.7 433.7 288 416 288H109.3l105.4 105.4c12.5 12.5 12.5 32.75 0 45.25C208.4 444.9 200.2 448 192 448s-16.38-3.125-22.62-9.375l-160-160c-12.5-12.5-12.5-32.75 0-45.25l160-160c12.5-12.5 32.75-12.5 45.25 0s12.5 32.75 0 45.25L109.3 224H416C433.7 224 447.1 238.3 447.1 256z"
                /></svg
            >
        </button>
    </section>
    <section>
        <h2 class="month">Tháng {date.getMonth() + 1}</h2>
        <h3 class="year">{date.getFullYear()}</h3>
    </section>
    <section>
        <button on:click={move(false)} title="Tháng sau">
            <svg
                aria-hidden="true"
                focusable="false"
                class="icon"
                role="img"
                xmlns="http://www.w3.org/2000/svg"
                viewBox="0 0 448 512"
                ><path
                    fill="currentColor"
                    d="M438.6 278.6l-160 160C272.4 444.9 264.2 448 256 448s-16.38-3.125-22.62-9.375c-12.5-12.5-12.5-32.75 0-45.25L338.8 288H32C14.33 288 .0016 273.7 .0016 256S14.33 224 32 224h306.8l-105.4-105.4c-12.5-12.5-12.5-32.75 0-45.25s32.75-12.5 45.25 0l160 160C451.1 245.9 451.1 266.1 438.6 278.6z"
                /></svg
            >
        </button>
    </section>
</header>

<style>
    header {
        background: #262626;
        color: #fff;
        align-items: center;
        display: grid;
        grid-template-columns: 1fr minmax(100px, 1fr) 1fr;
    }

    section {
        position: relative;
        padding: 1rem 0;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }

    .month {
        font-size: 1.5rem;
        font-weight: 600;
        margin: 0;
    }

    .year {
        font-size: 1.2rem;
        margin-top: 0.2rem;
        font-weight: 400;
        margin-bottom: 0;
    }

    .icon {
        width: 1.2rem;
        height: 1.2rem;
    }

    button {
        display: block;
        width: 3rem;
        height: 3rem;
        display: grid;
        place-content: center;
        border-radius: 50%;
        border: 0;
        background: none;
        color: #12cfe8;
        transition: all 0.2s;
    }

    button:hover {
        background: #12cfe8;
        color: #121212;
    }

    button:active {
        background: #0b7c8b;
    }
</style>
