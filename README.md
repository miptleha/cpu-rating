# Laptop СPU rating
It is difficult to determine the processor performance by its number. A newer processor may be weaker and more expensive. The speed of a laptop is a subjective characteristic and may be related not only to the processor, but also to the SSD and memory. Another important part of the processor is the graphics core.

This article is an attempt to make a summary table from which it will be clear what characteristics the processor has and what performance it has according to tests. I am only interested in those processors with which laptops can be bought cheaply in Russia.

<html>
<link href="https://cdn.jsdelivr.net/gh/tofsjonas/sortable@latest/sortable.min.css" rel="stylesheet" />
<script src="https://cdn.jsdelivr.net/gh/tofsjonas/sortable@latest/sortable.min.js"></script>
<script type="text/javascript">
  function addSortable() {
    var tags = document.getElementsByTagName("table");
    for (i = 0; i < tags.length; i++) {
		tags[i].className = "sortable";
	}
  }

window.boot.register('page-ready', () => {
    addSortable()
})
</script>
</html>

```json:table
{
    "fields" : [
        {"key": "a", "label": "Name", "sortable": true},
        {"key": "b", "label": "Core/Threads"},
        {"key": "c", "label": "Min/Max Frequency"},
        {"key", "d", "label": "Min/Max TDP"},
        {"key", "e", "label": "CPU-Z Single Thread Bench*", "sortable": true},
        {"key", "f", "label": "CPU-Z Single Multi Bench*", "sortable": true}
    ],
    "items" : [
      {"a": "AMD Ryzen 5 5500U", "b": "6/12", "c": "-", "d": "-", "e": "476", "f": "2536"},
      {"a": "Intel Core i5-12450H", "b": "6/12", "c": "-", "d": "-", "e": "673", "f": "4756"}
    ]
}
```

(*) sortable column
