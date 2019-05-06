function is_leap_year(year::Int)
    leap_year::Bool = false

    if(year % 4 != 0)
        leap_year = false
    elseif(year % 100 != 0)
        leap_year = true
    elseif(year % 400 != 0)
        leap_year = false
    else
        leap_year = true
    end

    return leap_year
end


#= better solution

function is_leap_year(year::Int)
  div_by(n) = year % n == 0
# or div_by = n -> year % n == 0
  div_by(4) && !div_by(100) || div_by(400)
end

=#
