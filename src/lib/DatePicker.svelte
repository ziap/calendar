<script>
    import { Lunar } from "lunar-calendar-ts-vi";

    /**@type {Date}*/
    export let date;

    const oneDay = 24 * 3600 * 1000;
    const lunar = new Lunar();

    $: month = date.getMonth();
    $: firstDay = new Date(date.getFullYear(), month, 1);
    $: firstDay.setDate(1 - firstDay.getDay());

    $: dates = Array.from(
        { length: 42 },
        (_, i) => new Date(firstDay.getTime() + i * oneDay)
    );
    $: lunars = dates.map((x) => lunar.getBlockLunarDate(x));
</script>

<header>
    <div class="weekday">CN</div>
    <div class="weekday">T2</div>
    <div class="weekday">T3</div>
    <div class="weekday">T4</div>
    <div class="weekday">T5</div>
    <div class="weekday">T6</div>
    <div class="weekday">T7</div>
</header>
<main>
    {#each dates as d, i}
        {#if d.getMonth() == month}
            <button
                class="date"
                title={d.toLocaleString('vi-VN', { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' })}
                class:active={d.getDate() == date.getDate()}
                on:click={() => (date = d)}
            >
                <div class="solar">{d.getDate()}</div>
                <div class="lunar">
                    {lunars[i].lunarDate}
                    {#if lunars[i].lunarDate == 1}
                        / {lunars[i].lunarMonth}
                    {/if}
                </div>
            </button>
        {:else}
            <div />
        {/if}
    {/each}
    <footer>
        <button class="today-btn" on:click={() => (date = new Date())}
            >Hôm nay</button
        >
    </footer>
</main>

<style>
    header {
        display: grid;
        padding: 0 2rem;
        grid-template-columns: repeat(7, 1fr);
        place-items: center;
        background: #262626;
        color: #fff;
    }

    .weekday {
        font-size: 1.2rem;
        padding: 1rem;
        font-weight: 400;
    }

    main {
        background: #121212;
        padding: 2rem;
        display: grid;
        grid-template-columns: repeat(7, 1fr);
        grid-template-rows: repeat(6, 1fr) minmax(min-content, max-content);
    }

    .date {
        background: none;
        border: none;
        color: #fff;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        transition: all 0.2s;
    }

    .date:hover {
        background: #2e2e2e;
    }

    .date.active {
        background: #12cfe8;
        color: #121212;
        margin: 0.5rem;
        border-radius: 1rem;
    }

    .solar {
        font-size: 1.5rem;
        font-weight: 500;
    }

    .lunar {
        font-size: 0.8rem;
        margin-top: 0.2rem;
    }

    footer {
        margin-top: 2rem;
        grid-column: span 7;
        display: flex;
        align-items: center;
    }

    .today-btn {
        background: none;
        border: none;
        color: #12cfe8;
        padding: 0.5rem 1.5rem;
        font-size: 1.2rem;
        border-radius: 3rem;
        transition: all 0.2s;
    }

    .today-btn:hover {
        background: #12cfe8;
        color: #121212;
    }
</style>
