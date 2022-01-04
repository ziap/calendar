<script>
    import Header from "$lib/Header.svelte";
    import Solar from "$lib/Solar.svelte";
    import Lunar from "$lib/Lunar.svelte";
    import DatePicker from "$lib/DatePicker.svelte";
    import { onMount } from "svelte";
    import Navigate from "$lib/Navigate.svelte";

    /**@type {Date}*/
    let date;
    onMount(() => (date = new Date()));
</script>

<svelte:head>
    <title>
        {date
            ? `${date.toLocaleDateString("vi-VN", { dateStyle: "full" })} - `
            : ""}
        Lịch vạn niên
    </title>
</svelte:head>

<Navigate bind:date />

{#if date}
    <div class="container">
        <Header bind:date />
        <div class="display">
            <Solar {date} />
            <Lunar {date} />
        </div>
        <DatePicker bind:date />
    </div>
{/if}

<style>
    .container {
        position: absolute;
        display: grid;
        grid-auto-flow: column;
        grid-template-columns: 3fr 5fr;
        grid-template-rows: minmax(min-content, max-content) 1fr;
        inset: 0;
    }

    .display {
        background: url("/bg.jpg") center / cover;
        display: flex;
        flex-direction: column;
        justify-content: space-between;
    }

    @media (max-width: 800px) {
        .display {
            display: none;
        }

        .container {
            grid-auto-flow: row;
            grid-template-columns: 1fr;
            grid-template-rows:
                minmax(min-content, max-content)
                minmax(min-content, min-content)
                1fr;
        }
    }
</style>
