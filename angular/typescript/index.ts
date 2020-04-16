
interface stringHelper{
    formatString(s: string): string;
}

class LowercasestringHelper implements stringHelper{
    formatString(s: string): string {
        return `${s.toLowerCase}`;
    }
}

const helper: stringHelper = new LowercasestringHelper();

document.addEventListener('DOMContentLoaded', () => {
    const element = document.createElement('p');

    element.textContent = "Hello TS";

    document.body.appendChild(element);
});