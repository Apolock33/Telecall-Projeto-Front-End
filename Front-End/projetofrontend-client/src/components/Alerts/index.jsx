
import Swal from "sweetalert2"

const useToastAlert = ({ texto, icon, hasConfirmButton, timer, hasProgressBar }) => {

    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: hasConfirmButton,
        timer: timer,
        timerProgressBar: hasProgressBar,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
            toast.addEventListener('click', () => { Swal.close() })
        }
    })

    return (
        Toast.fire({
            icon: icon,
            title: texto
        })
    );
}

export { useToastAlert };