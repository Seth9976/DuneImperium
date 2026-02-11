using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000040 RID: 64
	public class BasePopupField<TValueType, TValueChoice> : BaseField<TValueType>
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00030E08 File Offset: 0x0002F008
		// Note: this type is marked as 'beforefieldinit'.
		static BasePopupField()
		{
			Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BasePopupField`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueChoice>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr);
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "m_Choices");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "m_TextElement");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_ArrowElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "m_ArrowElement");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_FormatSelectedValueCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "m_FormatSelectedValueCallback");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_FormatListItemCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "m_FormatListItemCallback");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_createMenuCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "createMenuCallback");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "ussClassName");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_textUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "textUssClassName");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_arrowUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "arrowUssClassName");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "labelUssClassName");
			BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "inputUssClassName");
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_get_textElement_Protected_get_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664041);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_GetValueToDisplay_Internal_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664042);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_GetListItemToDisplay_Internal_Abstract_Virtual_New_String_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664043);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_AddMenuItems_Internal_Abstract_Virtual_New_Void_IGenericMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664044);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_set_choices_Public_Virtual_New_set_Void_List_1_TValueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664045);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664046);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664047);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664048);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664049);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664050);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664051);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664052);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664053);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_ShowMenu_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664054);
			BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, 100664055);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00031090 File Offset: 0x0002F290
		public unsafe TextElement textElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_get_textElement_Protected_get_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000310D0 File Offset: 0x0002F2D0
		[CallerCount(0)]
		public unsafe virtual string GetValueToDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_GetValueToDisplay_Internal_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00031114 File Offset: 0x0002F314
		[CallerCount(0)]
		public unsafe virtual string GetListItemToDisplay(TValueType item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = item;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_GetListItemToDisplay_Internal_Abstract_Virtual_New_String_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000311A0 File Offset: 0x0002F3A0
		[CallerCount(0)]
		public unsafe virtual void AddMenuItems(IGenericMenu menu)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(menu);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_AddMenuItems_Internal_Abstract_Virtual_New_Void_IGenericMenu_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000316E0 File Offset: 0x0002F8E0
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000311F0 File Offset: 0x0002F3F0
		public unsafe virtual List<TValueChoice> choices
		{
			get
			{
				return this.m_Choices;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289061, XrefRangeEnd = 289072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_set_choices_Public_Virtual_New_set_Void_List_1_TValueChoice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00031240 File Offset: 0x0002F440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289084, RefRangeEnd = 289085, XrefRangeStart = 289072, XrefRangeEnd = 289084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(TValueType newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = newValue;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000312C4 File Offset: 0x0002F4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289164, RefRangeEnd = 289165, XrefRangeStart = 289085, XrefRangeEnd = 289164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasePopupField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00031310 File Offset: 0x0002F510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289165, XrefRangeEnd = 289166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDownEvent(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00031354 File Offset: 0x0002F554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289166, XrefRangeEnd = 289172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUpEvent(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00031398 File Offset: 0x0002F598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289172, XrefRangeEnd = 289175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMoveEvent(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000313DC File Offset: 0x0002F5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289176, RefRangeEnd = 289177, XrefRangeStart = 289175, XrefRangeEnd = 289176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00031428 File Offset: 0x0002F628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289188, RefRangeEnd = 289190, XrefRangeStart = 289177, XrefRangeEnd = 289188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public void ProcessPointerDown<T>(PointerEventBase<T> evt) where T : PointerEventBase<T>, new()
		{
			/*
An exception occurred when decompiling this method (0600056E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UnityEngine.UIElements.BasePopupField`2::ProcessPointerDown<T>(UnityEngine.UIElements.PointerEventBase`1<T>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0003146C File Offset: 0x0002F66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289190, XrefRangeEnd = 289199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000314B0 File Offset: 0x0002F6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289199, XrefRangeEnd = 289205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_ShowMenu_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000314E4 File Offset: 0x0002F6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289205, XrefRangeEnd = 289406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00003BB2 File Offset: 0x00001DB2
		public BasePopupField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00031520 File Offset: 0x0002F720
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00003BBB File Offset: 0x00001DBB
		public unsafe List<TValueChoice> m_Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TValueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00031550 File Offset: 0x0002F750
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00003BDA File Offset: 0x00001DDA
		public unsafe TextElement m_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00031580 File Offset: 0x0002F780
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00003BF9 File Offset: 0x00001DF9
		public unsafe VisualElement m_ArrowElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_ArrowElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_ArrowElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x000315B0 File Offset: 0x0002F7B0
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00003C18 File Offset: 0x00001E18
		public unsafe Func<TValueChoice, string> m_FormatSelectedValueCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_FormatSelectedValueCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValueChoice, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_FormatSelectedValueCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000315E0 File Offset: 0x0002F7E0
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00003C37 File Offset: 0x00001E37
		public unsafe Func<TValueChoice, string> m_FormatListItemCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_FormatListItemCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValueChoice, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_m_FormatListItemCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00031610 File Offset: 0x0002F810
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00003C56 File Offset: 0x00001E56
		public unsafe Func<IGenericMenu> createMenuCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_createMenuCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGenericMenu>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_createMenuCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00031640 File Offset: 0x0002F840
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00003C75 File Offset: 0x00001E75
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00031660 File Offset: 0x0002F860
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00003C87 File Offset: 0x00001E87
		public unsafe static string textUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_textUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_textUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00031680 File Offset: 0x0002F880
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00003C99 File Offset: 0x00001E99
		public unsafe static string arrowUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_arrowUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_arrowUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000316A0 File Offset: 0x0002F8A0
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00003CAB File Offset: 0x00001EAB
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000316C0 File Offset: 0x0002F8C0
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00003CBD File Offset: 0x00001EBD
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x000316F8 File Offset: 0x0002F8F8
		public string text
		{
			get
			{
				return this.m_TextElement.text;
			}
		}

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_m_Choices;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_m_TextElement;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrowElement;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_m_FormatSelectedValueCallback;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_m_FormatListItemCallback;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_createMenuCallback;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_textUssClassName;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_arrowUssClassName;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_get_textElement_Protected_get_TextElement_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_GetValueToDisplay_Internal_Abstract_Virtual_New_String_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_GetListItemToDisplay_Internal_Abstract_Virtual_New_String_TValueType_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_AddMenuItems_Internal_Abstract_Virtual_New_Void_IGenericMenu_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_set_choices_Public_Virtual_New_set_Void_List_1_TValueChoice_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_ShowMenu_Internal_Void_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x02000332 RID: 818
		public class PopupTextElement : TextElement
		{
			// Token: 0x060035B0 RID: 13744 RVA: 0x000DE6D8 File Offset: 0x000DC8D8
			// Note: this type is marked as 'beforefieldinit'.
			static PopupTextElement()
			{
				Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.PopupTextElement>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "PopupTextElement"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueChoice>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.PopupTextElement>.NativeClassPtr);
				BasePopupField<TValueType, TValueChoice>.PopupTextElement.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.PopupTextElement>.NativeClassPtr, 100664057);
				BasePopupField<TValueType, TValueChoice>.PopupTextElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.PopupTextElement>.NativeClassPtr, 100664058);
			}

			// Token: 0x060035B1 RID: 13745 RVA: 0x000DE778 File Offset: 0x000DC978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289050, XrefRangeEnd = 289054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref desiredWidth;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredHeight;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasePopupField<TValueType, TValueChoice>.PopupTextElement.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060035B2 RID: 13746 RVA: 0x000DE7F8 File Offset: 0x000DC9F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289058, RefRangeEnd = 289059, XrefRangeStart = 289054, XrefRangeEnd = 289058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PopupTextElement()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.PopupTextElement>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.PopupTextElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035B3 RID: 13747 RVA: 0x00015E10 File Offset: 0x00014010
			public PopupTextElement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400268C RID: 9868
			private static readonly IntPtr NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0;

			// Token: 0x0400268D RID: 9869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000333 RID: 819
		[ObfuscatedName("UnityEngine.UIElements.BasePopupField`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060035B4 RID: 13748 RVA: 0x000DE834 File Offset: 0x000DCA34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueChoice>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr);
				BasePopupField<TValueType, TValueChoice>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr, "<>9");
				BasePopupField<TValueType, TValueChoice>.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr, "<>9__23_0");
				BasePopupField<TValueType, TValueChoice>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr, 100664060);
				BasePopupField<TValueType, TValueChoice>.__c.NativeMethodInfoPtr___ctor_b__23_0_Internal_Void_MouseDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr, 100664061);
			}

			// Token: 0x060035B5 RID: 13749 RVA: 0x000DE8FC File Offset: 0x000DCAFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePopupField<TValueType, TValueChoice>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035B6 RID: 13750 RVA: 0x000DE938 File Offset: 0x000DCB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289059, XrefRangeEnd = 289061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__23_0(MouseDownEvent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasePopupField<TValueType, TValueChoice>.__c.NativeMethodInfoPtr___ctor_b__23_0_Internal_Void_MouseDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060035B7 RID: 13751 RVA: 0x00015E19 File Offset: 0x00014019
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AA RID: 4266
			// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000DE97C File Offset: 0x000DCB7C
			// (set) Token: 0x060035B9 RID: 13753 RVA: 0x00015E22 File Offset: 0x00014022
			public unsafe static BasePopupField<TValueType, TValueChoice>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasePopupField<TValueType, TValueChoice>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AB RID: 4267
			// (get) Token: 0x060035BA RID: 13754 RVA: 0x000DE9A4 File Offset: 0x000DCBA4
			// (set) Token: 0x060035BB RID: 13755 RVA: 0x00015E34 File Offset: 0x00014034
			public unsafe static EventCallback<MouseDownEvent> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BasePopupField<TValueType, TValueChoice>.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<MouseDownEvent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BasePopupField<TValueType, TValueChoice>.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400268E RID: 9870
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400268F RID: 9871
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04002690 RID: 9872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002691 RID: 9873
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__23_0_Internal_Void_MouseDownEvent_0;
		}

		// Token: 0x02000334 RID: 820
		private sealed class MethodInfoStoreGeneric_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0
		{
			// Token: 0x060035BC RID: 13756 RVA: 0x000DE9CC File Offset: 0x000DCBCC
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0()
			{
				/*
An exception occurred when decompiling this method (060035BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UnityEngine.UIElements.BasePopupField`2/MethodInfoStoreGeneric_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x04002692 RID: 9874
			internal static IntPtr Pointer;
		}
	}
}
