interface CustomResponse {
    valid: boolean
    error: string
}

const validator = ( validatorFn?: () => CustomResponse ): CustomResponse => { 
    return { valid: false, error: 'error occurred' }
}

const errorResponse = (): CustomResponse => {
    return { valid: false, error: 'error occurred' }
}

console.log(validator(() => errorResponse()).valid)
console.log(validator().error)