<script>
    import Quote from "./Quote.svelte";

    export let date;

    const dayOfWeek = [
        "Chủ nhật",
        "Thứ hai",
        "Thứ ba",
        "Thứ tư",
        "Thứ năm",
        "Thứ sáu",
        "Thứ bảy",
    ];
</script>

<header>
    <h2 class="month">Tháng {date.getMonth()}</h2>
    <h3 class="year">{date.getFullYear()}</h3>
</header>
<main>
    <div class="date-wrapper">
        <h1 class="day">{date.getDate()}</h1>
        <h2 class="weekday">{dayOfWeek[date.getDay()]}</h2>
    </div>
    <Quote {date} />
</main>

<style>
    header {
        background-color: #fff;
        box-shadow: 0 3px 4px 0 rgba(0, 0, 0, 0.14),
            0 3px 3px -2px rgba(0, 0, 0, 0.12), 0 1px 8px 0 rgba(0, 0, 0, 0.2);
        padding: 1rem;
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    main {
        flex-grow: 1;
        padding: 1rem;
        display: flex;
        flex-direction: column;
        justify-content: space-evenly;
        align-items: center;
    }

    .date-wrapper {
        display: flex;
        flex-direction: column;
        align-items: center;
        margin: 1rem 0;
    }

    .day {
        line-height: 1em;
        margin: 0;
        font-size: 7.5rem;
    }

    .weekday {
        margin-top: 0.5rem;
        margin-bottom: 0;
        font-size: 2.5rem;
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
</style>
