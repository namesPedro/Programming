import os
import matplotlib.pyplot as plt

def read_data_from_file(filename):
    sizes = []
    list_times = []
    array_times = []

    with open(filename, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            if not line:
                continue

            size, list_time, array_time = map(float, line.split())
            sizes.append(size)
            list_times.append(list_time)
            array_times.append(array_time)

    return sizes, list_times, array_times


def plot_file(filename):
    sizes, list_times, array_times = read_data_from_file(filename)

    plt.figure(figsize=(8, 6))
    plt.plot(sizes, list_times, marker='o', label='List')
    plt.plot(sizes, array_times, marker='s', label='Array')

    plt.xlabel('Размер структуры')
    plt.ylabel('Среднее время')
    plt.title(f'Графики {filename}')
    plt.legend()
    plt.grid(True)

    plt.tight_layout()

    # имя png-файла
    png_name = os.path.splitext(filename)[0] + '.png'
    plt.savefig(png_name)
    plt.close()

    print(f'Сохранён график: {png_name}')


def main():
    txt_files = [f for f in os.listdir('.') if f.endswith('.txt') and os.path.isfile(f)]

    if not txt_files:
        print('Файлы .txt не найдены')
        return

    for filename in txt_files:
        try:
            plot_file(filename)
        except Exception as e:
            print(f'Ошибка при обработке {filename}: {e}')


if __name__ == '__main__':
    main()
