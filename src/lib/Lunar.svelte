<script>
    export let date;
    import { Lunar } from "lunar-calendar-ts-vi";

    const lunar = new Lunar();
    const lunarDate = lunar.getBlockLunarDate(date);
</script>

<footer class="lunar">
    <div class="card">
        <div class="card-header">Ngày</div>
        <div class="card-content">
            <h3>{lunarDate.lunarDate}</h3>
            <p>{lunarDate.lunarDateStr}</p>
        </div>
    </div>
    <div class="card">
        <div class="card-header">Tháng</div>
        <div class="card-content">
            <h3>{lunarDate.lunarMonth}</h3>
            <p>{lunarDate.lunarMonthStr}</p>
        </div>
    </div>
    <div class="card">
        <div class="card-header">Năm</div>
        <div class="card-content">
            <h3>{lunarDate.lunarYear}</h3>
            <p>{lunarDate.lunarYearStr}</p>
        </div>
    </div>
</footer>

<style>
    .lunar {
        background: #fff;
        box-shadow: 0 8px 10px 1px rgba(0, 0, 0, 0.14),
            0 3px 14px 2px rgba(0, 0, 0, 0.12),
            0 5px 5px -3px rgba(0, 0, 0, 0.2);
        display: flex;
    }

    .card {
        flex-grow: 1;
        display: flex;
        flex-direction: column;
        border-left: #eee 1.5px solid;
        border-right: #eee 1.5px solid;
    }

    .card-header {
        padding: 1rem;
        text-align: center;
        font-weight: 600;
        border-bottom: #eee 3px solid;
    }

    .card-content {
        flex-grow: 1;
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        padding: 1rem;
    }

    h3 {
        font-size: 1.8rem;
        margin: 0 0 0.5rem 0;
    }

    p {
        font-size: 1.2rem;
        margin: 0;
    }
</style>
