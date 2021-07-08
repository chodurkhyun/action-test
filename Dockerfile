FROM mono

RUN apt update
RUN apt install -y software-properties-common python3 python3-distutils
RUN curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py
RUN python3 ./get-pip.py
RUN rm ./get-pip.py
RUN pip install openpyxl
RUN mkdir /root/workspace/
RUN mkdir /root/workspace/output_
RUN ls /root/workspace
WORKDIR /root/workspace
ENTRYPOINT ["tail", "-f", "/dev/null"]
