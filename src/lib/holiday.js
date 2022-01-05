import holidays from "$lib/json/holidays.json"
import { Lunar } from "lunar-calendar-ts-vi"

const lunar = new Lunar()

/**
 * Determine whether a date is a holiday
 * @param {Date} date 
 * @returns {null | {name: string, when: string}}
 */
export default function getHoliday(date) {
    const dateStr = date.getDate() + '-' + (date.getMonth() + 1)
    const lunarDate = lunar.getBlockLunarDate(date)
    const lunarDateStr = lunarDate.lunarDate + '-' + lunarDate.lunarMonth
    if (holidays.solar[dateStr]) return {
        name: holidays.solar[dateStr],
        when: `${date.getDate()} tháng ${date.getMonth() + 1}`
    }
    if (holidays.lunar[lunarDateStr]) return {
        name: holidays.lunar[lunarDateStr],
        when: `${lunarDate.lunarDate} tháng ${lunarDate.lunarMonth} Âm Lịch`
    }
    return null
}