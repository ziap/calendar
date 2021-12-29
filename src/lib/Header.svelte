<script>
    /**@type {Date}*/
    export let date;

    function reset() {
        date = new Date();
    }
</script>

<header>
    <section>
        <button on:click={reset} title="Quay lại hôm nay">
            <svg
                xmlns="http://www.w3.org/2000/svg"
                class="icon"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
            >
                <path
                    stroke-linecap="round"
                    stroke-linejoin="round"
                    stroke-width="2"
                    d="M4 4v5h.582m15.356 2A8.001 8.001 0 004.582 9m0 0H9m11 11v-5h-.581m0 0a8.003 8.003 0 01-15.357-2m15.357 2H15"
                />
            </svg>
        </button>
    </section>
    <section>
        <h2 class="month">Tháng {date.getMonth() + 1}</h2>
        <h3 class="year">{date.getFullYear()}</h3>
        <div class="picker"></div>
    </section>
    <section>
        <button title="Chỉnh ngày" on:click={() => alert("WIP")}>
            <svg
                xmlns="http://www.w3.org/2000/svg"
                class="icon"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
            >
                <path
                    stroke-linecap="round"
                    stroke-linejoin="round"
                    stroke-width="2"
                    d="M15.232 5.232l3.536 3.536m-2.036-5.036a2.5 2.5 0 113.536 3.536L6.5 21.036H3v-3.572L16.732 3.732z"
                />
            </svg>
        </button>
    </section>
</header>

<style>
    header {
        background-color: #fff;
        box-shadow: 0 3px 4px 0 rgba(0, 0, 0, 0.14),
            0 3px 3px -2px rgba(0, 0, 0, 0.12), 0 1px 8px 0 rgba(0, 0, 0, 0.2);
        align-items: center;
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
    }

    section {
        position: relative;
        padding: 1rem;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }

    .month {
        font-size: 1.5rem;
        margin: 0;
    }

    .year {
        font-size: 1.2rem;
        margin-top: 0.2rem;
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
        background: #fff;
        box-shadow: 0 2px 2px 0 rgba(0, 0, 0, 0.14),
            0 3px 1px -2px rgba(0, 0, 0, 0.12), 0 1px 5px 0 rgba(0, 0, 0, 0.2);
    }

    button:hover {
        background: #e5e5e5;
        box-shadow: 0 4px 5px 0 rgba(0, 0, 0, 0.14),
            0 1px 10px 0 rgba(0, 0, 0, 0.12), 0 2px 4px -1px rgba(0, 0, 0, 0.2);
    }

    button:active {
        background: #d4d4d4;
        box-shadow: 0 6px 10px 0 rgba(0, 0, 0, 0.14),
            0 1px 18px 0 rgba(0, 0, 0, 0.12), 0 3px 5px -1px rgba(0, 0, 0, 0.2);
    }

    .picker {
        display: none;
        position: absolute;
        top: 100%;
        margin-top: 1.5rem;
        width: 200px;
        box-shadow: 0 8px 10px 1px rgba(0,0,0,0.14), 0 3px 14px 2px rgba(0,0,0,0.12), 0 5px 5px -3px rgba(0,0,0,0.20);
        background: #fff;
        height: 200px;
    }
</style>
