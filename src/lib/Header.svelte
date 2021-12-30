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
                    d="M77.25 256l137.4-137.4c12.5-12.5 12.5-32.75 0-45.25s-32.75-12.5-45.25 0l-160 160c-12.5 12.5-12.5 32.75 0 45.25l160 160C175.6 444.9 183.8 448 192 448s16.38-3.125 22.62-9.375c12.5-12.5 12.5-32.75 0-45.25L77.25 256zM269.3 256l137.4-137.4c12.5-12.5 12.5-32.75 0-45.25s-32.75-12.5-45.25 0l-160 160c-12.5 12.5-12.5 32.75 0 45.25l160 160C367.6 444.9 375.8 448 384 448s16.38-3.125 22.62-9.375c12.5-12.5 12.5-32.75 0-45.25L269.3 256z"
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
                    d="M246.6 233.4l-160-160c-12.5-12.5-32.75-12.5-45.25 0s-12.5 32.75 0 45.25L178.8 256l-137.4 137.4c-12.5 12.5-12.5 32.75 0 45.25C47.63 444.9 55.81 448 64 448s16.38-3.125 22.62-9.375l160-160C259.1 266.1 259.1 245.9 246.6 233.4zM438.6 233.4l-160-160c-12.5-12.5-32.75-12.5-45.25 0s-12.5 32.75 0 45.25L370.8 256l-137.4 137.4c-12.5 12.5-12.5 32.75 0 45.25C239.6 444.9 247.8 448 256 448s16.38-3.125 22.62-9.375l160-160C451.1 266.1 451.1 245.9 438.6 233.4z"
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
