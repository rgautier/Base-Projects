if ARGV.length < 1 
  puts "You must tell me how many digits to compute to.\n"
elsif ARGV.length > 1
  puts "Too many parameters.  Just tell me the number of digits to compute.\n"
else
	print "Now computing pi to "
	print ARGV[0]
	print " digit(s).\n"

	digits = ARGV[0]

	#Assumption - digits is a positive integer - add checks
	for counter in (1..digits.to_i)
          thisdigit = 0
          for i in (0..counter)
	    thisdigit += 16.0**(-1.0*i)*(4.0/(8.0*i+1.0) - 2.0/(8.0*i+4.0) -1.0/(8.0*i+5.0) - 1.0/(8.0*i+6.0))
          end
          print thisdigit
          print "\t"	
	end
end

