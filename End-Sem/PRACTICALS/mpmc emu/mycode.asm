
; You may customize this and other start-up templates; 
; The location of this template is c:\emu8086\inc\0_com_template.txt

org 100h

MOV AX,0FFFH;
MOV CX,0001H;
MOV [1234H],AX;
MOV [1236H],CX;
ADD AX,CX; 

ret




