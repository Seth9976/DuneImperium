using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000143 RID: 323
	public sealed class ReflectPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06001326 RID: 4902 RVA: 0x00065EB8 File Offset: 0x000640B8
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectPropertyDescriptor()
		{
			Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ReflectPropertyDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr);
			ReflectPropertyDescriptor.NativeFieldInfoPtr_argsNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "argsNone");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_noValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "noValue");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_PropDescCreateSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "PropDescCreateSwitch");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_PropDescUsageSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "PropDescUsageSwitch");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitDefaultValueQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitDefaultValueQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitGetQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitGetQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitSetQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitSetQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitShouldSerializeQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitShouldSerializeQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitResetQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitResetQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitChangedQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitChangedQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitIPropChangedQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitIPropChangedQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitReadOnlyChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitReadOnlyChecked");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitAmbientValueQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitAmbientValueQueried");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_BitSetOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "BitSetOnDemand");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "state");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_componentClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "componentClass");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "type");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "defaultValue");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_ambientValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "ambientValue");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_propInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "propInfo");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_getMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "getMethod");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_setMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "setMethod");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_shouldSerializeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "shouldSerializeMethod");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_resetMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "resetMethod");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_realChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "realChangedEvent");
			ReflectPropertyDescriptor.NativeFieldInfoPtr_receiverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, "receiverType");
			ReflectPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666078);
			ReflectPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_PropertyInfo_MethodInfo_MethodInfo_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666079);
			ReflectPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_Type_MethodInfo_MethodInfo_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666080);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_AmbientValue_Private_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666081);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666082);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_DefaultValue_Private_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666083);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_GetMethodValue_Private_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666084);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_IsExtender_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666085);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666086);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666087);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_ResetMethodValue_Private_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666088);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_SetMethodValue_Private_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666089);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_get_ShouldSerializeMethodValue_Private_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666090);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderCanResetValue_Internal_Boolean_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666091);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderGetReceiverType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666092);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderGetType_Internal_Type_IExtenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666093);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderGetValue_Internal_Object_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666094);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderResetValue_Internal_Void_IExtenderProvider_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666095);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderSetValue_Internal_Void_IExtenderProvider_Object_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666096);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderShouldSerializeValue_Internal_Boolean_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666097);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666098);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666099);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666100);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666101);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666102);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666103);
			ReflectPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr, 100666104);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0006630C File Offset: 0x0006450C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461476, RefRangeEnd = 461478, XrefRangeStart = 461466, XrefRangeEnd = 461476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectPropertyDescriptor(Type componentClass, string name, Type type, Il2CppReferenceArray<Attribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00066390 File Offset: 0x00064590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461494, RefRangeEnd = 461495, XrefRangeStart = 461478, XrefRangeEnd = 461494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Il2CppReferenceArray<Attribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getMethod);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setMethod);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_PropertyInfo_MethodInfo_MethodInfo_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0006644C File Offset: 0x0006464C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461504, RefRangeEnd = 461505, XrefRangeStart = 461495, XrefRangeEnd = 461504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Il2CppReferenceArray<Attribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectPropertyDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiverType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getMethod);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setMethod);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_Type_MethodInfo_MethodInfo_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00066508 File Offset: 0x00064708
		public unsafe Object AmbientValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 461525, RefRangeEnd = 461530, XrefRangeStart = 461505, XrefRangeEnd = 461525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_AmbientValue_Private_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00066548 File Offset: 0x00064748
		public unsafe override Type ComponentType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00066588 File Offset: 0x00064788
		public unsafe Object DefaultValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 461551, RefRangeEnd = 461561, XrefRangeStart = 461530, XrefRangeEnd = 461551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_DefaultValue_Private_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000665C8 File Offset: 0x000647C8
		public unsafe MethodInfo GetMethodValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 461598, RefRangeEnd = 461602, XrefRangeStart = 461561, XrefRangeEnd = 461598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_GetMethodValue_Private_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00066608 File Offset: 0x00064808
		public unsafe bool IsExtender
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461602, XrefRangeEnd = 461606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_IsExtender_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00066644 File Offset: 0x00064844
		public unsafe override bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461606, XrefRangeEnd = 461611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00066680 File Offset: 0x00064880
		public unsafe override Type PropertyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000666C0 File Offset: 0x000648C0
		public unsafe MethodInfo ResetMethodValue
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 461643, RefRangeEnd = 461651, XrefRangeStart = 461611, XrefRangeEnd = 461643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_ResetMethodValue_Private_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00066700 File Offset: 0x00064900
		public unsafe MethodInfo SetMethodValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 461716, RefRangeEnd = 461721, XrefRangeStart = 461651, XrefRangeEnd = 461716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_SetMethodValue_Private_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00066740 File Offset: 0x00064940
		public unsafe MethodInfo ShouldSerializeMethodValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 461753, RefRangeEnd = 461756, XrefRangeStart = 461721, XrefRangeEnd = 461753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_get_ShouldSerializeMethodValue_Private_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00066780 File Offset: 0x00064980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461782, RefRangeEnd = 461783, XrefRangeStart = 461756, XrefRangeEnd = 461782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExtenderCanResetValue(IExtenderProvider provider, Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderCanResetValue_Internal_Boolean_IExtenderProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000667E0 File Offset: 0x000649E0
		[CallerCount(0)]
		public unsafe Type ExtenderGetReceiverType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderGetReceiverType_Internal_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00066820 File Offset: 0x00064A20
		[CallerCount(0)]
		public unsafe Type ExtenderGetType(IExtenderProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderGetType_Internal_Type_IExtenderProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00066870 File Offset: 0x00064A70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 461785, RefRangeEnd = 461791, XrefRangeStart = 461783, XrefRangeEnd = 461785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ExtenderGetValue(IExtenderProvider provider, Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderGetValue_Internal_Object_IExtenderProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000668D4 File Offset: 0x00064AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461843, RefRangeEnd = 461844, XrefRangeStart = 461791, XrefRangeEnd = 461843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExtenderResetValue(IExtenderProvider provider, Object component, PropertyDescriptor notifyDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notifyDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderResetValue_Internal_Void_IExtenderProvider_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0006693C File Offset: 0x00064B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 461881, RefRangeEnd = 461883, XrefRangeStart = 461844, XrefRangeEnd = 461881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExtenderSetValue(IExtenderProvider provider, Object component, Object value, PropertyDescriptor notifyDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notifyDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderSetValue_Internal_Void_IExtenderProvider_Object_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000669B8 File Offset: 0x00064BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 461898, RefRangeEnd = 461899, XrefRangeStart = 461883, XrefRangeEnd = 461898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExtenderShouldSerializeValue(IExtenderProvider provider, Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ExtenderShouldSerializeValue_Internal_Boolean_IExtenderProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00066A18 File Offset: 0x00064C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461899, XrefRangeEnd = 461921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanResetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00066A68 File Offset: 0x00064C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 461921, XrefRangeEnd = 462037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FillAttributes(IList attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00066AAC File Offset: 0x00064CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462037, XrefRangeEnd = 462044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00066AFC File Offset: 0x00064CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462044, XrefRangeEnd = 462051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(Object component, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00066B50 File Offset: 0x00064D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462051, XrefRangeEnd = 462096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00066B94 File Offset: 0x00064D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462096, XrefRangeEnd = 462137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object component, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00066BE8 File Offset: 0x00064DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 462137, XrefRangeEnd = 462146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSerializeValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00008BBE File Offset: 0x00006DBE
		public ReflectPropertyDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00066C38 File Offset: 0x00064E38
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x00008BC7 File Offset: 0x00006DC7
		public unsafe static Il2CppReferenceArray<Type> argsNone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_argsNone, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_argsNone, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00066C60 File Offset: 0x00064E60
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x00008BD9 File Offset: 0x00006DD9
		public unsafe static Object noValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_noValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_noValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00066C88 File Offset: 0x00064E88
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00008BEB File Offset: 0x00006DEB
		public unsafe static TraceSwitch PropDescCreateSwitch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_PropDescCreateSwitch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceSwitch>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_PropDescCreateSwitch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00066CB0 File Offset: 0x00064EB0
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00008BFD File Offset: 0x00006DFD
		public unsafe static TraceSwitch PropDescUsageSwitch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_PropDescUsageSwitch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceSwitch>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_PropDescUsageSwitch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00066CD8 File Offset: 0x00064ED8
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x00008C0F File Offset: 0x00006E0F
		public unsafe static int BitDefaultValueQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitDefaultValueQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitDefaultValueQueried, (void*)(&value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00066CF4 File Offset: 0x00064EF4
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x00008C1D File Offset: 0x00006E1D
		public unsafe static int BitGetQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitGetQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitGetQueried, (void*)(&value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00066D10 File Offset: 0x00064F10
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x00008C2B File Offset: 0x00006E2B
		public unsafe static int BitSetQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitSetQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitSetQueried, (void*)(&value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00066D2C File Offset: 0x00064F2C
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x00008C39 File Offset: 0x00006E39
		public unsafe static int BitShouldSerializeQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitShouldSerializeQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitShouldSerializeQueried, (void*)(&value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00066D48 File Offset: 0x00064F48
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00008C47 File Offset: 0x00006E47
		public unsafe static int BitResetQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitResetQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitResetQueried, (void*)(&value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00066D64 File Offset: 0x00064F64
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00008C55 File Offset: 0x00006E55
		public unsafe static int BitChangedQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitChangedQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitChangedQueried, (void*)(&value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00066D80 File Offset: 0x00064F80
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00008C63 File Offset: 0x00006E63
		public unsafe static int BitIPropChangedQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitIPropChangedQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitIPropChangedQueried, (void*)(&value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00066D9C File Offset: 0x00064F9C
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00008C71 File Offset: 0x00006E71
		public unsafe static int BitReadOnlyChecked
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitReadOnlyChecked, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitReadOnlyChecked, (void*)(&value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00066DB8 File Offset: 0x00064FB8
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x00008C7F File Offset: 0x00006E7F
		public unsafe static int BitAmbientValueQueried
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitAmbientValueQueried, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitAmbientValueQueried, (void*)(&value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00066DD4 File Offset: 0x00064FD4
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00008C8D File Offset: 0x00006E8D
		public unsafe static int BitSetOnDemand
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitSetOnDemand, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectPropertyDescriptor.NativeFieldInfoPtr_BitSetOnDemand, (void*)(&value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00066DF0 File Offset: 0x00064FF0
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00008C9B File Offset: 0x00006E9B
		public unsafe BitVector32 state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00066E18 File Offset: 0x00065018
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00008CB6 File Offset: 0x00006EB6
		public unsafe Type componentClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_componentClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_componentClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00066E48 File Offset: 0x00065048
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00008CD5 File Offset: 0x00006ED5
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00066E78 File Offset: 0x00065078
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public unsafe Object defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00066EA8 File Offset: 0x000650A8
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00008D13 File Offset: 0x00006F13
		public unsafe Object ambientValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_ambientValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_ambientValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00066ED8 File Offset: 0x000650D8
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00008D32 File Offset: 0x00006F32
		public unsafe PropertyInfo propInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_propInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_propInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00066F08 File Offset: 0x00065108
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00008D51 File Offset: 0x00006F51
		public unsafe MethodInfo getMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_getMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_getMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00066F38 File Offset: 0x00065138
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00008D70 File Offset: 0x00006F70
		public unsafe MethodInfo setMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_setMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_setMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00066F68 File Offset: 0x00065168
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00008D8F File Offset: 0x00006F8F
		public unsafe MethodInfo shouldSerializeMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_shouldSerializeMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_shouldSerializeMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00066F98 File Offset: 0x00065198
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00008DAE File Offset: 0x00006FAE
		public unsafe MethodInfo resetMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_resetMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_resetMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00066FC8 File Offset: 0x000651C8
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x00008DCD File Offset: 0x00006FCD
		public unsafe EventDescriptor realChangedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_realChangedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_realChangedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00066FF8 File Offset: 0x000651F8
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x00008DEC File Offset: 0x00006FEC
		public unsafe Type receiverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_receiverType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectPropertyDescriptor.NativeFieldInfoPtr_receiverType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_argsNone;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_noValue;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_PropDescCreateSwitch;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_PropDescUsageSwitch;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_BitDefaultValueQueried;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_BitGetQueried;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_BitSetQueried;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_BitShouldSerializeQueried;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_BitResetQueried;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_BitChangedQueried;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_BitIPropChangedQueried;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_BitReadOnlyChecked;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_BitAmbientValueQueried;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_BitSetOnDemand;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_componentClass;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_ambientValue;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr_propInfo;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_getMethod;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_setMethod;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_shouldSerializeMethod;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_resetMethod;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeFieldInfoPtr_realChangedEvent;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeFieldInfoPtr_receiverType;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_PropertyInfo_MethodInfo_MethodInfo_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Type_Type_MethodInfo_MethodInfo_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientValue_Private_get_Object_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Private_get_Object_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_get_GetMethodValue_Private_get_MethodInfo_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExtender_Private_get_Boolean_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_get_ResetMethodValue_Private_get_MethodInfo_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_get_SetMethodValue_Private_get_MethodInfo_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSerializeMethodValue_Private_get_MethodInfo_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderCanResetValue_Internal_Boolean_IExtenderProvider_Object_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderGetReceiverType_Internal_Type_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderGetType_Internal_Type_IExtenderProvider_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderGetValue_Internal_Object_IExtenderProvider_Object_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderResetValue_Internal_Void_IExtenderProvider_Object_PropertyDescriptor_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderSetValue_Internal_Void_IExtenderProvider_Object_Object_PropertyDescriptor_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_ExtenderShouldSerializeValue_Internal_Boolean_IExtenderProvider_Object_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Object_EventArgs_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0;
	}
}
