using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D3 RID: 467
	public class StyleVariableResolver : Object
	{
		// Token: 0x06002442 RID: 9282 RVA: 0x000A2B84 File Offset: 0x000A0D84
		// Note: this type is marked as 'beforefieldinit'.
		static StyleVariableResolver()
		{
			Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleVariableResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr);
			StyleVariableResolver.NativeFieldInfoPtr_kMaxResolves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "kMaxResolves");
			StyleVariableResolver.NativeFieldInfoPtr_s_SyntaxParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "s_SyntaxParser");
			StyleVariableResolver.NativeFieldInfoPtr_m_Matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_Matcher");
			StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_ResolvedValues");
			StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedVarStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_ResolvedVarStack");
			StyleVariableResolver.NativeFieldInfoPtr_m_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_Property");
			StyleVariableResolver.NativeFieldInfoPtr_m_ContextStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_ContextStack");
			StyleVariableResolver.NativeFieldInfoPtr_m_CurrentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_CurrentContext");
			StyleVariableResolver.NativeFieldInfoPtr__variableContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "<variableContext>k__BackingField");
			StyleVariableResolver.NativeMethodInfoPtr_get_currentSheet_Private_get_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668792);
			StyleVariableResolver.NativeMethodInfoPtr_get_currentHandles_Private_get_Il2CppStructArray_1_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668793);
			StyleVariableResolver.NativeMethodInfoPtr_get_resolvedValues_Public_get_List_1_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668794);
			StyleVariableResolver.NativeMethodInfoPtr_get_variableContext_Public_get_StyleVariableContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668795);
			StyleVariableResolver.NativeMethodInfoPtr_set_variableContext_Public_set_Void_StyleVariableContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668796);
			StyleVariableResolver.NativeMethodInfoPtr_Init_Public_Void_StyleProperty_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668797);
			StyleVariableResolver.NativeMethodInfoPtr_PushContext_Private_Void_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668798);
			StyleVariableResolver.NativeMethodInfoPtr_PopContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668799);
			StyleVariableResolver.NativeMethodInfoPtr_AddValue_Public_Void_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668800);
			StyleVariableResolver.NativeMethodInfoPtr_ResolveVarFunction_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668801);
			StyleVariableResolver.NativeMethodInfoPtr_ResolveVarFunction_Private_Result_byref_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668802);
			StyleVariableResolver.NativeMethodInfoPtr_ValidateResolvedValues_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668803);
			StyleVariableResolver.NativeMethodInfoPtr_ResolveVariable_Private_Result_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668804);
			StyleVariableResolver.NativeMethodInfoPtr_ResolveFallback_Private_Result_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668805);
			StyleVariableResolver.NativeMethodInfoPtr_ParseVarFunction_Private_Static_Void_StyleSheet_Il2CppStructArray_1_StyleValueHandle_byref_Int32_byref_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668806);
			StyleVariableResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100668807);
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000A2DA8 File Offset: 0x000A0FA8
		public unsafe StyleSheet currentSheet
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_get_currentSheet_Private_get_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000A2DE8 File Offset: 0x000A0FE8
		public unsafe Il2CppStructArray<StyleValueHandle> currentHandles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_get_currentHandles_Private_get_Il2CppStructArray_1_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000A2E28 File Offset: 0x000A1028
		public unsafe List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> resolvedValues
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_get_resolvedValues_Public_get_List_1_StylePropertyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000A2E68 File Offset: 0x000A1068
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x000A2EA8 File Offset: 0x000A10A8
		public unsafe StyleVariableContext variableContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_get_variableContext_Public_get_StyleVariableContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_set_variableContext_Public_set_Void_StyleVariableContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x000A2EEC File Offset: 0x000A10EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338193, RefRangeEnd = 338194, XrefRangeStart = 338185, XrefRangeEnd = 338193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(StyleProperty property, StyleSheet sheet, Il2CppStructArray<StyleValueHandle> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_Init_Public_Void_StyleProperty_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x000A2F54 File Offset: 0x000A1154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338200, RefRangeEnd = 338201, XrefRangeStart = 338194, XrefRangeEnd = 338200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushContext(StyleSheet sheet, Il2CppStructArray<StyleValueHandle> handles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_PushContext_Private_Void_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x000A2FA8 File Offset: 0x000A11A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338201, XrefRangeEnd = 338209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_PopContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x000A2FDC File Offset: 0x000A11DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338213, RefRangeEnd = 338214, XrefRangeStart = 338209, XrefRangeEnd = 338213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_AddValue_Public_Void_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x000A301C File Offset: 0x000A121C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338232, RefRangeEnd = 338233, XrefRangeStart = 338214, XrefRangeEnd = 338232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveVarFunction(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_ResolveVarFunction_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x000A3068 File Offset: 0x000A1268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338245, RefRangeEnd = 338246, XrefRangeStart = 338233, XrefRangeEnd = 338245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableResolver.Result ResolveVarFunction(ref int index, int argc, string varName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(varName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_ResolveVarFunction_Private_Result_byref_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x000A30D4 File Offset: 0x000A12D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338259, RefRangeEnd = 338260, XrefRangeStart = 338246, XrefRangeEnd = 338259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateResolvedValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_ValidateResolvedValues_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000A3110 File Offset: 0x000A1310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338271, RefRangeEnd = 338273, XrefRangeStart = 338260, XrefRangeEnd = 338271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableResolver.Result ResolveVariable(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_ResolveVariable_Private_Result_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x000A3160 File Offset: 0x000A1360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338296, RefRangeEnd = 338298, XrefRangeStart = 338273, XrefRangeEnd = 338296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableResolver.Result ResolveFallback(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_ResolveFallback_Private_Result_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000A31AC File Offset: 0x000A13AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338311, RefRangeEnd = 338312, XrefRangeStart = 338298, XrefRangeEnd = 338311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseVarFunction(StyleSheet sheet, Il2CppStructArray<StyleValueHandle> handles, ref int index, out int argCount, out string variableName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &argCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr_ParseVarFunction_Private_Static_Void_StyleSheet_Il2CppStructArray_1_StyleValueHandle_byref_Int32_byref_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			variableName = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x000A322C File Offset: 0x000A142C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338339, RefRangeEnd = 338340, XrefRangeStart = 338312, XrefRangeEnd = 338339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0000EEB9 File Offset: 0x0000D0B9
		public StyleVariableResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x000A3268 File Offset: 0x000A1468
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0000EEC2 File Offset: 0x0000D0C2
		public unsafe static int kMaxResolves
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StyleVariableResolver.NativeFieldInfoPtr_kMaxResolves, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleVariableResolver.NativeFieldInfoPtr_kMaxResolves, (void*)(&value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x000A3284 File Offset: 0x000A1484
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		public unsafe static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleVariableResolver.NativeFieldInfoPtr_s_SyntaxParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleVariableResolver.NativeFieldInfoPtr_s_SyntaxParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x000A32AC File Offset: 0x000A14AC
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x0000EEE2 File Offset: 0x0000D0E2
		public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Matcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000A32DC File Offset: 0x000A14DC
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x0000EF01 File Offset: 0x0000D101
		public unsafe List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x000A330C File Offset: 0x000A150C
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x0000EF20 File Offset: 0x0000D120
		public unsafe Stack<string> m_ResolvedVarStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedVarStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedVarStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000A333C File Offset: 0x000A153C
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x0000EF3F File Offset: 0x0000D13F
		public unsafe StyleProperty m_Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000A336C File Offset: 0x000A156C
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0000EF5E File Offset: 0x0000D15E
		public unsafe Stack<StyleVariableResolver.ResolveContext> m_ContextStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ContextStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<StyleVariableResolver.ResolveContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ContextStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000A339C File Offset: 0x000A159C
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x0000EF7D File Offset: 0x0000D17D
		public StyleVariableResolver.ResolveContext m_CurrentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_CurrentContext);
				return new StyleVariableResolver.ResolveContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_CurrentContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000A33CC File Offset: 0x000A15CC
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x0000EFAB File Offset: 0x0000D1AB
		public unsafe StyleVariableContext _variableContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr__variableContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr__variableContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeFieldInfoPtr_kMaxResolves;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeFieldInfoPtr_s_SyntaxParser;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr_m_Matcher;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolvedValues;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolvedVarStack;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeFieldInfoPtr_m_Property;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeFieldInfoPtr_m_ContextStack;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentContext;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeFieldInfoPtr__variableContext_k__BackingField;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSheet_Private_get_StyleSheet_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_get_currentHandles_Private_get_Il2CppStructArray_1_StyleValueHandle_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_get_resolvedValues_Public_get_List_1_StylePropertyValue_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr_get_variableContext_Public_get_StyleVariableContext_0;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_set_variableContext_Public_set_Void_StyleVariableContext_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_StyleProperty_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_PushContext_Private_Void_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_PopContext_Private_Void_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_StyleValueHandle_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_ResolveVarFunction_Public_Boolean_byref_Int32_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_ResolveVarFunction_Private_Result_byref_Int32_Int32_String_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_ValidateResolvedValues_Public_Boolean_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_ResolveVariable_Private_Result_String_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFallback_Private_Result_byref_Int32_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_ParseVarFunction_Private_Static_Void_StyleSheet_Il2CppStructArray_1_StyleValueHandle_byref_Int32_byref_Int32_byref_String_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004E4 RID: 1252
		public enum Result
		{
			// Token: 0x04002CA2 RID: 11426
			Valid,
			// Token: 0x04002CA3 RID: 11427
			Invalid,
			// Token: 0x04002CA4 RID: 11428
			NotFound
		}

		// Token: 0x020004E5 RID: 1253
		public sealed class ResolveContext : ValueType
		{
			// Token: 0x06003F1E RID: 16158 RVA: 0x000FBB9C File Offset: 0x000F9D9C
			// Note: this type is marked as 'beforefieldinit'.
			static ResolveContext()
			{
				Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "ResolveContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr);
				StyleVariableResolver.ResolveContext.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr, "sheet");
				StyleVariableResolver.ResolveContext.NativeFieldInfoPtr_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr, "handles");
			}

			// Token: 0x06003F1F RID: 16159 RVA: 0x0001A75F File Offset: 0x0001895F
			public ResolveContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003F20 RID: 16160 RVA: 0x0001A768 File Offset: 0x00018968
			public ResolveContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariableResolver.ResolveContext>.NativeClassPtr))
			{
			}

			// Token: 0x170012F6 RID: 4854
			// (get) Token: 0x06003F21 RID: 16161 RVA: 0x000FBBF0 File Offset: 0x000F9DF0
			// (set) Token: 0x06003F22 RID: 16162 RVA: 0x0001A77A File Offset: 0x0001897A
			public unsafe StyleSheet sheet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.ResolveContext.NativeFieldInfoPtr_sheet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.ResolveContext.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F7 RID: 4855
			// (get) Token: 0x06003F23 RID: 16163 RVA: 0x000FBC20 File Offset: 0x000F9E20
			// (set) Token: 0x06003F24 RID: 16164 RVA: 0x0001A799 File Offset: 0x00018999
			public unsafe Il2CppStructArray<StyleValueHandle> handles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.ResolveContext.NativeFieldInfoPtr_handles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.ResolveContext.NativeFieldInfoPtr_handles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CA5 RID: 11429
			private static readonly IntPtr NativeFieldInfoPtr_sheet;

			// Token: 0x04002CA6 RID: 11430
			private static readonly IntPtr NativeFieldInfoPtr_handles;
		}
	}
}
