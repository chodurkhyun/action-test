from collections import OrderedDict
import subprocess
import os
from openpyxl import load_workbook 

if not os.path.exists('./output_'):
    os.mkdir('./output_')

wb = load_workbook(filename='./test.xlsx')

for ws in wb:
    print(ws.title)

    names = [x[0] for x in ws.iter_rows(min_col=1, max_col=1, min_row=2, values_only=True)]
    print(names)

    res_dict = OrderedDict()
    for c in ws.iter_cols(values_only=True):
        res_dict[c[0]] = c[1:]

    print(res_dict)

    print(res_dict.keys())

    for k in list(res_dict.keys())[1:]:
        print([f'{n}={v}' for n, v in zip(res_dict['name'], res_dict[k])])
        with open('tmp.txt', 'w') as f:
            f.writelines([f'{n}={v}\n' for n, v in zip(res_dict['name'], res_dict[k])])

        subprocess.run(['resgen', 'tmp.txt', f'/root/workspace/output_/{ws.title}.{k}.resx'])

os.remove('tmp.txt')
