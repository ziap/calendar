<script>
    import Quote from "./Quote.svelte";

    /**@type {Date}*/
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

<main>
    <div class="date-wrapper">
        <h1 class="day">{date.getDate()}</h1>
        <h2 class="weekday">{dayOfWeek[date.getDay()]}</h2>
    </div>
    <Quote {date} />
</main>

<style>
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
</style>
