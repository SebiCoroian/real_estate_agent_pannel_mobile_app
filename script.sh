#!/usr/bin/env bash

INITIAL="Real_Estate_Agency"
FINAL="Real_Estate_Agency"

for todo in $(find . -type f -or -type d -name "*${INITIAL}*")
do
	FILENAME="$(echo "${todo}" | rg "${INITIAL}" -r "${FINAL}")"
	echo "Replacing ${todo} to ${FILENAME}"
	mv "${todo}" "${FILENAME}"
done
