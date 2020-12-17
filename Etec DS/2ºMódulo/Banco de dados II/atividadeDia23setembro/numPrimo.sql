declare @numInferior int,@numSuperior int,@controle tinyint,@inicio int,@contador int
set @numInferior=2
	set @numSuperior=5000

		while @numInferior<=@numSuperior
			begin

			set @inicio=1
				set @contador=0
				while @inicio <=@numInferior
					begin
					if @numInferior%@inicio = 0
					set @contador = @contador+1
						set @inicio = @inicio+1

						end

						if @contador>2
							set @controle=0
						else 
							set @controle=1

				if @controle=1 
				print @numInferior

				set @numInferior= @numInferior+1
			end