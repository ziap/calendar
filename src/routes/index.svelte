<script>
    import { onMount } from "svelte";
    import Solar from "$lib/Solar.svelte";
    import Lunar from "$lib/Lunar.svelte";

    /**@type {Date}*/
    let date;

    onMount(() => (date = new Date()));
</script>

<svelte:head>
    {#if date}
        <title
            >{date.toLocaleString("vi-VN", {
                weekday: "long",
                year: "numeric",
                month: "long",
                day: "numeric",
            })} | Lịch vạn niên</title
        >
    {:else}
        <title>Lịch vạn niên</title>
    {/if}
</svelte:head>
<div class="container">
    <img src="/bg.jpg" alt="background" />
    {#if date}
        <header>
            <h2 class="month">Tháng {date.getMonth() + 1}</h2>
            <h3 class="year">{date.getFullYear()}</h3>
        </header>
        <Solar {date} />
        <Lunar {date} />
    {/if}
</div>

<style>
    * {
        font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto,
            Oxygen, Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
    }

    .container {
        position: absolute;
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        inset: 0;
        overflow: hidden;
    }

    img {
        z-index: -1;
        position: absolute;
        inset: 0;
        width: 100%;
        height: 100%;
        object-fit: cover;
    }

    header {
        background-color: #fff;
        box-shadow: 0 3px 4px 0 rgba(0, 0, 0, 0.14),
            0 3px 3px -2px rgba(0, 0, 0, 0.12), 0 1px 8px 0 rgba(0, 0, 0, 0.2);
        padding: 1rem;
        display: flex;
        flex-direction: column;
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
</style>
