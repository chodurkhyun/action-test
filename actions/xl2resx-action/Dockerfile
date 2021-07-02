FROM mono

RUN apt update
RUN apt install -y software-properties-common python3 python3-distutils
RUN curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py
RUN python3 ./get-pip.py
RUN rm ./get-pip.py
RUN pip install openpyxl
RUN mkdir /github/workspace
RUN mkdir /github/workspace/output
WORKDIR /github/workspace
# ENTRYPOINT ["tail", "-f", "/dev/null"]
ENTRYPOINT ["python3", "xl2resx.py"]
