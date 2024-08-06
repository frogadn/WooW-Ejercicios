public class WoFormGroupView : AWoCommonFormViewBase
{
    #region Icono

    /// <summary>
    /// Representa el icono.
    /// </summary>
    private eBoostrapIcons _icon = eBoostrapIcons.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el icono.
    /// </summary>
    public event EventHandler<eBoostrapIcons>? ChangeIconEvt;

    /// <summary>
    /// Método para cambiar el ícono.
    /// </summary>
    public void ChangeIcon(eBoostrapIcons icon)
    {
        _icon = icon;
        InvokeChangeIcon();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeIcon()
    {
        ChangeIconEvt?.Invoke(this, _icon);
    }

    #endregion Icono

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public override void ActualizarComponente()
    {
        InvokeChangeIcon();
    }

    #endregion Actualización general del render del componente
}

public class WoFormTabView : AWoCommonFormViewBase
{
    #region Icon

    /// <summary>
    /// Representa el icono.
    /// </summary>
    private eBoostrapIcons _icon = eBoostrapIcons.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el icono.
    /// </summary>
    public event EventHandler<eBoostrapIcons>? ChangeIconEvt;

    /// <summary>
    /// Método para cambiar el ícono.
    /// </summary>
    public void ChangeIcon(eBoostrapIcons icon)
    {
        _icon = icon;
        InvokeChangeIcon();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeIcon()
    {
        ChangeIconEvt?.Invoke(this, _icon);
    }

    #endregion Icon

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public override void ActualizarComponente()
    {
        InvokeChangeIcon();
    }

    #endregion Actualización general del render del componente
}

public class WoFormView : AWoCommonFormViewBase
{
}

public class AWoCommonFormViewBase
{
    #region Color del fondo

    /// <summary>
    /// Representa el color del fondo.
    /// </summary>
    private eGroupColor _backColor = eGroupColor.Default;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color del fondo.
    /// </summary>
    public event EventHandler<eGroupColor>? ChangeBackColorEvt;

    /// <summary>
    /// Cambiar color del fondo desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeFondo(eGroupColor color)
    {
        _backColor = color;
        InvokeChangeBackGround();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeBackGround()
    {
        ChangeBackColorEvt?.Invoke(this, _backColor);
    }

    #endregion Color del fondo


    #region Fuente

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _fontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetra(eTextWeight negrita)
    {
        _fontWeight = negrita;
        InvokeChangeFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontWeight()
    {
        ChangeFontWeightEvt?.Invoke(this, _fontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _fontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void Italica(eTextItalic italica)
    {
        _fontItalic = italica;
        InvokeChangeFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontItalic()
    {
        ChangeFontItalicEvt?.Invoke(this, _fontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _fontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetra(eTextDecoration decoracion)
    {
        _fontDecoration = decoracion;
        InvokeChangeFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontDecoration()
    {
        ChangeFontDecorationEvt?.Invoke(this, _fontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Color de fuente

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _fontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetra(eTextColor color)
    {
        _fontColor = color;
        InvokeChangeFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeFontColor()
    {
        ChangeFontColorEvt?.Invoke(this, _fontColor);
    }

    #endregion Color de fuente

    #endregion Fuente


    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public virtual void ActualizarComponente()
    {
        InvokeChangeFontColor();
        InvokeChangeFontWeight();
        InvokeChangeFontItalic();
        InvokeChangeFontDecoration();
        InvokeChangeBackGround();
    }

    #endregion Actualización general del render del componente
}


public class WoEditView : AWoCommonEditViewBase
{
}

public class AWoCommonEditViewBase
{
    #region Color del fondo

    /// <summary>
    /// Representa el color del fondo.
    /// </summary>
    private eContainerItemColor _backColor = eContainerItemColor.Default;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color del fondo.
    /// </summary>
    public event EventHandler<eContainerItemColor>? ChangeBackColorEvt;

    /// <summary>
    /// Cambiar color del fondo desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeFondo(eContainerItemColor color)
    {
        _backColor = color;
        InvokeChangeBackGround();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeBackGround()
    {
        ChangeBackColorEvt?.Invoke(this, _backColor);
    }

    #endregion Color del fondo


    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _controlFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeControlFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeControl(eTextColor color)
    {
        _controlFontColor = color;
        InvokeChangeControlFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontColor()
    {
        ChangeControlFontColorEvt?.Invoke(this, _controlFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _controlFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeControlFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeControl(eTextWeight negrita)
    {
        _controlFontWeight = negrita;
        InvokeChangeControlFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontWeight()
    {
        ChangeControlFontWeightEvt?.Invoke(this, _controlFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _controlFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeControlFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void ControlEnItalica(eTextItalic italica)
    {
        _controlFontItalic = italica;
        InvokeChangeControlFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontItalic()
    {
        ChangeControlFontItalicEvt?.Invoke(this, _controlFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _controlFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeControlFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeControl(eTextDecoration decoracion)
    {
        _controlFontDecoration = decoracion;
        InvokeChangeControlFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeControlFontDecoration()
    {
        ChangeControlFontDecorationEvt?.Invoke(this, _controlFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _size = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetra(eItemSize tamaño)
    {
        _size = tamaño;
        InvokeChangeSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeSize()
    {
        ChangeSizeEvt?.Invoke(this, _size);
    }

    #endregion Tamaño de letra


    #region Des/Habilitar control

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _status = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeEnabledEvt;

    /// <summary>
    /// Método con los que interactue el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    public void EstadoHabilitado(bool estado)
    {
        _status = estado;
        InvokeChangeEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeEnabled()
    {
        ChangeEnabledEvt?.Invoke(this, _status);
    }

    #endregion Des/Habilitar control


    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public void ActualizarComponente()
    {
        InvokeChangeControlFontWeight();
        InvokeChangeControlFontItalic();
        InvokeChangeControlFontDecoration();
        InvokeChangeBackGround();
        InvokeChangeSize();
        InvokeChangeEnabled();
    }

    #endregion Actualización general del render del componente
}


public class WoFormItemView
{
    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _CaptionFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeCaptionFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeTitulo(eTextColor color)
    {
        _CaptionFontColor = color;
        InvokeChangeCaptionFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontColor()
    {
        ChangeCaptionFontColorEvt?.Invoke(this, _CaptionFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _captionFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeCaptionFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeTitulo(eTextWeight negrita)
    {
        _captionFontWeight = negrita;
        InvokeChangeCaptionFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontWeight()
    {
        ChangeCaptionFontWeightEvt?.Invoke(this, _captionFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _captionFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeCaptionFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void TtuloEnItalica(eTextItalic italica)
    {
        _captionFontItalic = italica;
        InvokeChangeCaptionFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontItalic()
    {
        ChangeCaptionFontItalicEvt?.Invoke(this, _captionFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _captionFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeCaptionFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeTitulo(eTextDecoration decoracion)
    {
        _captionFontDecoration = decoracion;
        InvokeChangeCaptionFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeCaptionFontDecoration()
    {
        ChangeCaptionFontDecorationEvt?.Invoke(this, _captionFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _size = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetra(eItemSize tamaño)
    {
        _size = tamaño;
        InvokeChangeSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeSize()
    {
        ChangeSizeEvt?.Invoke(this, _size);
    }

    #endregion Tamaño de letra
}


public class WoInputAlertView
{
    /// <summary>
    /// Informacion que contendra la alerta del componente.
    /// </summary>
    private string _value = string.Empty;

    #region Agregar Alerta

    /// <summary>
    /// Controlador de eventos para enviar el valor de la alerta a la alerta interna.
    /// </summary>
    public event EventHandler<string>? SetAlertValueEvt;

    /// <summary>
    /// Permite asignar el valor de la alerta del input.
    /// </summary>
    /// <param name="value"></param>
    public void AgregarAlerta(string value)
    {
        _value = value;
        SetAlertValueEvt?.Invoke(this, value);
    }

    #endregion Agregar Alerta

    #region Limpiar Alertas

    /// <summary>
    /// Controlador de eventos para limpiar las alertas del componente.
    /// </summary>
    public event EventHandler? ClearAlertsEvt;

    /// <summary>
    /// Metodo visible para el usuario para limpiar las alertas.
    /// </summary>
    public void LimpiarAlertas()
    {
        ClearAlertsEvt?.Invoke(this, EventArgs.Empty);
    }

    #endregion Limpiar Alertas
}


public class WoFormToolbarView
{
    #region Des/Habilitar navegación

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _navigationStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeNavigationEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoNavegacion(bool NavegacionHabilitada)
    {
        _navigationStatus = NavegacionHabilitada;
        InvokeChangeNavigationEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeNavigationEnabled()
    {
        ChangeNavigationEnabledEvt?.Invoke(this, _navigationStatus);
    }

    #endregion Des/Habilitar navegación

    #region Des/Habilitar botones navegación

    #region First

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _firstStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnFirstEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnPrimeroHabilitado(bool estado)
    {
        _firstStatus = estado;
        InvokeChangeBtnFirstEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnFirstEnabled()
    {
        ChangeBtnFirstEnabledEvt?.Invoke(this, _firstStatus);
    }

    #endregion First

    #region Prior

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _priorStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnPriorEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnAnteriorHabilitado(bool estado)
    {
        _priorStatus = estado;
        InvokeChangeBtnPriorEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnPriorEnabled()
    {
        ChangeBtnPriorEnabledEvt?.Invoke(this, _priorStatus);
    }

    #endregion Prior

    #region Next

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _nextStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnNextEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnSiguienteHabilitado(bool estado)
    {
        _nextStatus = estado;
        InvokeChangeBtnNextEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnNextEnabled()
    {
        ChangeBtnNextEnabledEvt?.Invoke(this, _nextStatus);
    }

    #endregion Next

    #region Last

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _lastStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeBtnLastEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoBtnUltimoHabilitado(bool estado)
    {
        _lastStatus = estado;
        InvokeChangeBtnLastEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeBtnLastEnabled()
    {
        ChangeBtnLastEnabledEvt?.Invoke(this, _lastStatus);
    }

    #endregion Last

    #endregion Des/Habilitar botones navegación



    #region Des/Habilitar Combo transiciones

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _transitionComboStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeTransitionEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    public void EstadoBarraDeTransicion(bool estado)
    {
        _transitionComboStatus = estado;
        InvokeChangeTransitionComboEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeTransitionComboEnabled()
    {
        ChangeTransitionEnabledEvt?.Invoke(this, _transitionComboStatus);
    }

    #endregion Des/Habilitar Combo transiciones

    #region Des/Habilitar botones transiciones

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _transitionButtonsStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeTransitionButtonsEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="estado">Define si los botones de acción de las transiciones se habilitan.</param>
    public void EstadoBotonesDeTransicion(bool estado)
    {
        _transitionButtonsStatus = estado;
        InvokeChangeTransitionButtonEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeTransitionButtonEnabled()
    {
        ChangeTransitionButtonsEnabledEvt?.Invoke(this, _transitionButtonsStatus);
    }

    #endregion Des/Habilitar botones transiciones

    #region Des/Habilitar botón de eliminar

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _deleteButtonsStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeDeleteButtonsEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="estado">Define si los botones de acción de delete se habilitan.</param>
    public void EstadoBotonesDeDelete(bool estado)
    {
        _deleteButtonsStatus = estado;
        InvokeChangeDeleteButtonEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeDeleteButtonEnabled()
    {
        ChangeDeleteButtonsEnabledEvt?.Invoke(this, _deleteButtonsStatus);
    }

    #endregion Des/Habilitar botón de eliminar

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public void ActualizarComponente()
    {
        InvokeChangeTransitionButtonEnabled();
        InvokeChangeTransitionComboEnabled();
        InvokeChangeNavigationEnabled();
    }

    #endregion Actualización general del render del componente
}


public class WoShareButtonView
{
    #region Des/Habilitar Botón

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _shareStatus = true;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeShareEnabledEvt;

    /// <summary>
    /// Método con los que interactúa el usuario desde el editor para
    /// habilitar o deshabilitar el control.
    /// </summary>
    /// <param name="NavegacionHabilitada">Define si la navegación se habilita o no</param>
    public void EstadoHabilitado(bool estadoHabilitado)
    {
        _shareStatus = estadoHabilitado;
        InvokeChangeShareEnabled();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos de la 
    /// habilitación del control y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeShareEnabled()
    {
        ChangeShareEnabledEvt?.Invoke(this, _shareStatus);
    }

    #endregion Des/Habilitar Botón
}


public class WoFormAlertView
{
	#region Variables globales base

	/// <summary>
	/// Lista de alertas que no se pudieron agregar al componente.
	/// </summary>
	private List<WoFormAlertModel> _alerts = new List<WoFormAlertModel>();

	/// <summary>
	/// Permite la implementación de mutex sobre la clase para proteger algoritmos.
	/// </summary>
	private static readonly object _lockObject = new object();

	#endregion Variables globales base

	#region Agregar alerta

	/// <summary>
	/// Controlador de eventos al cual suscribir el método para agregar
	/// alertas del componente.
	/// </summary>
	public EventHandler<WoFormAlertModel>? AddAlertEvt;

	/// <summary>
	/// Método para agregar alertas por parte del código del usuario o
	/// de por parte de algún otro componente.
	/// </summary>
	/// <param name="mensaje"></param>
	/// <param name="tipoDeAlerta"></param>
	/// <param name="siempreEnPantalla"></param>
	/// <param name="tiempo"></param>
	public void AgregarAlerta(
		string mensaje,
		eTipoDeAlerta tipoDeAlerta = eTipoDeAlerta.Error,
		bool siempreEnPantalla = false,
		int tiempo = 5)
	{
		lock (_lockObject)
		{
			if (_alerts.Where(x => x.Message == mensaje).FirstOrDefault() == null)
			{
				WoFormAlertModel alert = new WoFormAlertModel(
					message: mensaje,
					alertType: tipoDeAlerta,
					alwaysOnDisplay: siempreEnPantalla,
					time: tiempo
				);

				alert.CloseAlertEvt += (sender, e) =>
				{
					RemoverAlerta(e);
				};

				_alerts.Add(alert);

				if (AddAlertEvt != null)
				{
					AddAlertEvt.Invoke(this, alert);
				}
			}
		}
	}

	#endregion Agregar alerta

	#region Remover alerta

	/// <summary>
	/// Controlador de eventos al que se suscribirá el método para
	/// remover las alertas dentro del componente.
	/// </summary>
	public EventHandler<string>? RemoveAlertEvt;

	/// <summary>
	/// Método que puede detonarse desde el código del usuario o
	/// desde la parcial para remover alertas.
	/// Detona el controlador de eventos para remover alertas.
	/// </summary>
	/// <param name="mensaje"></param>
	public void RemoverAlerta(string mensaje)
	{
		lock (_lockObject)
		{
			WoFormAlertModel? alert = _alerts.Where(x => x.Message == mensaje).FirstOrDefault();
			if (alert != null)
			{
				_alerts.Remove(alert);
			}
			RemoveAlertEvt?.Invoke(this, mensaje);
		}
	}

	#endregion Remover alerta

	#region Limpiar todo

	/// <summary>
	/// Delegado a partir del cual se creara el controlador de eventos
	/// para métodos sin parámetros.
	/// </summary>
	public delegate void EventHandlerVoid();
	/// <summary>
	/// Controlador de eventos creado a partir del delegado.
	/// Se le suscribirá el método para limpiar las alertas en el componente.
	/// </summary>
	public EventHandlerVoid? CleanAlertsEvt;

	/// <summary>
	/// Método que permite eliminar todas las alertas desde el código del usuario
	/// o desde la parcial.
	/// </summary>
	public void RemoverTodasLasAlertas()
	{
		lock (_lockObject)
		{
			_alerts.Clear();
			CleanAlertsEvt?.Invoke();
		}
	}

	#endregion Limpiar todo

	#region Sincronización

	/// <summary>
	/// Se ocupa de actualizar el componente con la lista
	/// de la vista.
	/// </summary>
	public void ActualizarComponente()
	{
		if (_alerts.Count > 0)
		{
			if (AddAlertEvt != null)
			{
				foreach (var alert in _alerts)
				{
					AddAlertEvt?.Invoke(this, alert);
				}
			}
		}
	}

	#endregion Sincronización
}

public class WoFormAlertModel
    {
        #region Variables globales

        /// <summary>
        /// Texto que contendrá la alerta.
        /// </summary>
        public string Message = string.Empty;

        /// <summary>
        /// Tiempo que permanece la alerta
        /// </summary>
        private int _time { get; set; } = 5;

        /// <summary>
        /// Bandera para saver si se mantiene siempre hasta que el usuario
        /// u otro evento la cierre.
        /// </summary>
        private bool _alwaysOnDisplay = false;

		#endregion Variables globales

		#region Tipo de alerta

		/// <summary>
		/// Tipo de alerta.
		/// </summary>
		private eTipoDeAlerta AlertType
		{
			get;
			set;
			
		}
		/// <summary>
		/// Permite operar con el tipo de alerta sin el parámetro.
		/// </summary>
		private eTipoDeAlerta _alertType;

		/// <summary>
		/// Representa la clase CSS con el diseño de la alerta.
		/// </summary>
		private string _alertTypeClass = string.Empty;

		#endregion Tipo de alerta

		#region Constructores

		/// <summary>
		/// Como todas las propiedades son privadas se bloquea el constructor vació.
		/// </summary>
		private WoFormAlertModel() { }

        /// <summary>
        /// Constructor principal para la generación de alertas.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="alertType"></param>
        /// <param name="alwaysOnDisplay"></param>
        /// <param name="time"></param>
        public WoFormAlertModel(string message,
            eTipoDeAlerta alertType = eTipoDeAlerta.Error,
            bool alwaysOnDisplay = false,
            int time = 5
        )
        {
        }

        #endregion Constructores

        #region Timer

        /// <summary>
        /// Controlador de eventos al cual suscribir el evento para sacar la alerta de la lista.
        /// </summary>
        public EventHandler<string>? CloseAlertEvt;

        /// <summary>
        /// Método suscrito al controlador de eventos del timer.
        /// Detiene el timer y detona el EventCallBack.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CloseAlert(object? sender, EventArgs args)
        {
        }

        /// <summary>
        /// Inicia el timer en caso de que no sea siempre en la pantalla.
        /// </summary>
        public void StartTimer()
        {
        }

        /// <summary>
        /// Detiene y saca de memoria el timer.
        /// </summary>
        public void StopTimer()
        {
        }

        #endregion Timer
    }

public class WoDetailGridView
{
    #region Habilitar/deshabilitar edición

    /// <summary>
    /// Indica si el control esta habilitado.
    /// </summary>
    private bool _editionModeStatus = false;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar si el componente esta habilitado o des habilitado.
    /// </summary>
    public event EventHandler<bool>? ChangeEditionModeEvt;

    public void EstadoHabilitado(bool estado)
    {
        _editionModeStatus = estado;
        InvokeChangeEditionMode();
    }

    private void InvokeChangeEditionMode() => ChangeEditionModeEvt?.Invoke(this, _editionModeStatus);

    #endregion Habilitar/deshabilitar edición

    #region Customización

    #region Header

    #region Color de Fondo

    private eContainerItemColor _headerBackgroundColor = eContainerItemColor.Default;

    public EventHandler<eContainerItemColor>? ChangeHeaderBackgroundColorEvt;

    public void ColorDeFondeDeEncabezado(eContainerItemColor color)
    {
        _headerBackgroundColor = color;
        InvokeChangeHeaderBGColor();
    }

    private void InvokeChangeHeaderBGColor() => ChangeHeaderBackgroundColorEvt?.Invoke(this, _headerBackgroundColor);

    #endregion Color de Fondo

    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _headerFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeHeaderFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeEncabezado(eTextColor color)
    {
        _headerFontColor = color;
        InvokeChangeHeaderFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontColor()
    {
        ChangeHeaderFontColorEvt?.Invoke(this, _headerFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _headerFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeHeaderFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeEncabezado(eTextWeight negrita)
    {
        _headerFontWeight = negrita;
        InvokeChangeHeaderFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontWeight()
    {
        ChangeHeaderFontWeightEvt?.Invoke(this, _headerFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _headerFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeHeaderFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void EncabezadoEnItalica(eTextItalic italica)
    {
        _headerFontItalic = italica;
        InvokeChangeHeaderFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontItalic()
    {
        ChangeHeaderFontItalicEvt?.Invoke(this, _headerFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _headerFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeHeaderFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeTitulo(eTextDecoration decoracion)
    {
        _headerFontDecoration = decoracion;
        InvokeChangeHeaderFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeHeaderFontDecoration()
    {
        ChangeHeaderFontDecorationEvt?.Invoke(this, _headerFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _headerFontSize = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeHeaderFontSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetraDeEncabezado(eItemSize tamaño)
    {
        _headerFontSize = tamaño;
        InvokeChangeHeaderFontSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeHeaderFontSize()
    {
        ChangeHeaderFontSizeEvt?.Invoke(this, _headerFontSize);
    }

    #endregion Tamaño de letra

    #endregion Header

    #region Filas

    #region Color de Fondo 1

    private eContainerItemColor _rowsColor1 = eContainerItemColor.Default;

    public EventHandler<eContainerItemColor>? ChangeRowsBackgroundColor1Evt;

    public void ColorDeFondeDeFilas1(eContainerItemColor color)
    {
        _rowsColor1 = color;
        InvokeChangeRowsBGColor1();
    }

    private void InvokeChangeRowsBGColor1() => ChangeRowsBackgroundColor1Evt?.Invoke(this, _rowsColor1);

    #endregion Color de Fondo 1

    #region Color de Fondo 2

    private eContainerItemColor? _rowsColor2 = eContainerItemColor.Default;

    public EventHandler<eContainerItemColor?>? ChangeRowsBackgroundColor2Evt;

    public void ColorDeFondeDeFilas2(eContainerItemColor? color)
    {
        //if(color != null)
        _rowsColor2 = color;
        InvokeChangeRowsBGColor2();
    }

    private void InvokeChangeRowsBGColor2() => ChangeRowsBackgroundColor2Evt?.Invoke(this, _rowsColor2);

    #endregion Color de Fondo 2

    #region Color de Letra

    /// <summary>
    /// Representa el calor del color de la letra.
    /// </summary>
    private eTextColor _rowsFontColor = eTextColor.FontDefault;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el color de letra.
    /// </summary>
    public event EventHandler<eTextColor>? ChangeRowsFontColorEvt;

    /// <summary>
    /// Cambiar color de la letra desde el script o otro lado.
    /// </summary>
    /// <param name="newColor"></param>
    public void ColorDeLetraDeFilas(eTextColor color)
    {
        _rowsFontColor = color;
        InvokeChangeRowsFontColor();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontColor()
    {
        ChangeRowsFontColorEvt?.Invoke(this, _rowsFontColor);
    }

    #endregion Color de Letra

    #region Negrita

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextWeight _rowsFontWeight = eTextWeight.Normal;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextWeight>? ChangeRowsFontWeightEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void GrosorDeLetraDeFilas(eTextWeight negrita)
    {
        _rowsFontWeight = negrita;
        InvokeChangeRowsFontWeight();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontWeight()
    {
        ChangeRowsFontWeightEvt?.Invoke(this, _rowsFontWeight);
    }

    #endregion Negrita

    #region Italica

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextItalic _rowsFontItalic = eTextItalic.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextItalic>? ChangeRowsFontItalicEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void FilasEnItalica(eTextItalic italica)
    {
        _rowsFontItalic = italica;
        InvokeChangeRowsFontItalic();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontItalic()
    {
        ChangeRowsFontItalicEvt?.Invoke(this, _rowsFontItalic);
    }

    #endregion Italica

    #region Tachado/Subrayado

    /// <summary>
    /// Representa el tipo de fuente.
    /// </summary>
    private eTextDecoration _rowsFontDecoration = eTextDecoration.None;

    /// <summary>
    /// Controlador de eventos que se disparara al actualizar el tipo de letra.
    /// </summary>
    public event EventHandler<eTextDecoration>? ChangeRowsFontDecorationEvt;

    /// <summary>
    /// Método para cambiar el tipo de letra.
    /// </summary>
    public void DecoracionDeLetraDeFilas(eTextDecoration decoracion)
    {
        _rowsFontDecoration = decoracion;
        InvokeChangeRowsFontDecoration();
    }

    /// <summary>
    /// Detona el controlador de eventos, donde debe de estar suscrito el evento de actualización
    /// del componente.
    /// </summary>
    private void InvokeChangeRowsFontDecoration()
    {
        ChangeRowsFontDecorationEvt?.Invoke(this, _rowsFontDecoration);
    }

    #endregion Tachado/Subrayado

    #region Tamaño de letra

    /// <summary>
    /// Representa el valor del tamaño del control.
    /// </summary>
    private eItemSize _RowsFontSize = eItemSize.Small;

    /// <summary>
    /// Controlador de eventos que permite detonar los métodos que se suscriban especializados
    /// en modificar el tamaño del componente.
    /// </summary>
    public event EventHandler<eItemSize>? ChangeRowsFontSizeEvt;

    /// <summary>
    /// Métodos con los que interactue el usuario desde el editor para modificar el
    /// tamaño del control.
    /// </summary>
    public void TamañoDeLetraDeFilas(eItemSize tamaño)
    {
        _RowsFontSize = tamaño;
        InvokeChangeRowsFontSize();
    }

    /// <summary>
    /// Detona el método que se aya suscrito al controlador de eventos del cambio de tamaño y le pasa el valor asignado.
    /// </summary>
    private void InvokeChangeRowsFontSize()
    {
        ChangeRowsFontSizeEvt?.Invoke(this, _RowsFontSize);
    }

    #endregion Tamaño de letra

    #endregion Filas

    #endregion Customización

    #region Actualización general del render del componente

    /// <summary>
    /// Actualiza el renderizado del componente para que 
    /// se le pasen los datos de la view al componente.
    /// Nota: Hay que realizar esto luego de suscribir los eventos
    /// puesto que los usara para actualizar el renderizado.
    /// </summary>
    public void ActualizarComponente()
    {
        InvokeChangeEditionMode();

        InvokeChangeHeaderFontColor();
        InvokeChangeHeaderFontSize();
        InvokeChangeHeaderFontItalic();
        InvokeChangeHeaderFontDecoration();
        InvokeChangeHeaderFontWeight();
        InvokeChangeHeaderBGColor();

        InvokeChangeRowsFontColor();
        InvokeChangeRowsFontSize();
        InvokeChangeRowsFontItalic();
        InvokeChangeRowsFontDecoration();
        InvokeChangeRowsFontWeight();
        InvokeChangeRowsBGColor1();
        InvokeChangeRowsBGColor2();
    }

    #endregion Actualización general del render del componente
}
