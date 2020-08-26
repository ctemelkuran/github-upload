# Pay the hourly rate for the hours up to 40 and 1.5 times the hourly rate for all hours worked above 40 hours.
#You should use input to read a string and float() to convert the string to a number.

inph = input("How many hours:")
inpr = input("Enter the hourly rate:")
hrs = float(inph)
rt = float(inpr)

if hrs <= 40:
    ttl=hrs*rt

else:
    ttl=rt*(40+(hrs-40)*1.5)
print("Pay:",ttl)
