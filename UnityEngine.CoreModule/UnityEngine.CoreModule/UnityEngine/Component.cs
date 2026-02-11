using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000135 RID: 309
	public class Component : Object
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x00070C94 File Offset: 0x0006EE94
		// Note: this type is marked as 'beforefieldinit'.
		static Component()
		{
			Il2CppClassPointerStore<Component>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Component");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Component>.NativeClassPtr);
			Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666550);
			Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666551);
			Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666552);
			Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666553);
			Component.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666554);
			Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666555);
			Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666556);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666557);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666558);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666559);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666560);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666561);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666562);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666563);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666564);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666565);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666566);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666567);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666568);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666569);
			Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666570);
			Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666571);
			Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666572);
			Component.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666573);
			Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666574);
			Component.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666575);
			Component.NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666576);
			Component.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100666577);
			Component.GetComponentDelegateField = IL2CPP.ResolveICall<Component.GetComponentDelegate>("UnityEngine.Component::GetComponent");
			Component.GetComponentIndexDelegateField = IL2CPP.ResolveICall<Component.GetComponentIndexDelegate>("UnityEngine.Component::GetComponentIndex");
			Component.SendMessageUpwardsDelegateField = IL2CPP.ResolveICall<Component.SendMessageUpwardsDelegate>("UnityEngine.Component::SendMessageUpwards");
			Component.BroadcastMessageDelegateField = IL2CPP.ResolveICall<Component.BroadcastMessageDelegate>("UnityEngine.Component::BroadcastMessage");
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00070F30 File Offset: 0x0006F130
		public unsafe Transform transform
		{
			[CallerCount(688)]
			[CachedScanResults(RefRangeStart = 661903, RefRangeEnd = 662591, XrefRangeStart = 661901, XrefRangeEnd = 661903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00070F70 File Offset: 0x0006F170
		public unsafe GameObject gameObject
		{
			[CallerCount(698)]
			[CachedScanResults(RefRangeStart = 662593, RefRangeEnd = 663291, XrefRangeStart = 662591, XrefRangeEnd = 662593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00070FB0 File Offset: 0x0006F1B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 663296, RefRangeEnd = 663300, XrefRangeStart = 663291, XrefRangeEnd = 663296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00071000 File Offset: 0x0006F200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 663302, RefRangeEnd = 663303, XrefRangeStart = 663300, XrefRangeEnd = 663302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00071050 File Offset: 0x0006F250
		[CallerCount(557)]
		[CachedScanResults(RefRangeStart = 663309, RefRangeEnd = 663866, XrefRangeStart = 663303, XrefRangeEnd = 663309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0007108C File Offset: 0x0006F28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 663881, RefRangeEnd = 663882, XrefRangeStart = 663866, XrefRangeEnd = 663881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent(Type type, out Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			component = ((intPtr4 == 0) ? null : new Component(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x000710FC File Offset: 0x0006F2FC
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 663896, RefRangeEnd = 663963, XrefRangeStart = 663882, XrefRangeEnd = 663896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent<T>(out T component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref component;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00071188 File Offset: 0x0006F388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 663968, RefRangeEnd = 663970, XrefRangeStart = 663963, XrefRangeEnd = 663968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type t, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000711E8 File Offset: 0x0006F3E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 663977, RefRangeEnd = 663979, XrefRangeStart = 663970, XrefRangeEnd = 663977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00071230 File Offset: 0x0006F430
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 663986, RefRangeEnd = 664016, XrefRangeStart = 663979, XrefRangeEnd = 663986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x0007126C File Offset: 0x0006F46C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 664020, RefRangeEnd = 664028, XrefRangeStart = 664016, XrefRangeEnd = 664020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000712B0 File Offset: 0x0006F4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 664032, RefRangeEnd = 664033, XrefRangeStart = 664028, XrefRangeEnd = 664032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00071300 File Offset: 0x0006F500
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 664038, RefRangeEnd = 664056, XrefRangeStart = 664033, XrefRangeEnd = 664038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00071338 File Offset: 0x0006F538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 664061, RefRangeEnd = 664064, XrefRangeStart = 664056, XrefRangeEnd = 664061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0007137C File Offset: 0x0006F57C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 664069, RefRangeEnd = 664071, XrefRangeStart = 664064, XrefRangeEnd = 664069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type t, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x000713DC File Offset: 0x0006F5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664071, XrefRangeEnd = 664078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00071424 File Offset: 0x0006F624
		[CallerCount(111)]
		[CachedScanResults(RefRangeStart = 664085, RefRangeEnd = 664196, XrefRangeStart = 664078, XrefRangeEnd = 664085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00071460 File Offset: 0x0006F660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 664200, RefRangeEnd = 664202, XrefRangeStart = 664196, XrefRangeEnd = 664200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x000714A4 File Offset: 0x0006F6A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 664206, RefRangeEnd = 664211, XrefRangeStart = 664202, XrefRangeEnd = 664206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000714F4 File Offset: 0x0006F6F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 664216, RefRangeEnd = 664221, XrefRangeStart = 664211, XrefRangeEnd = 664216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0007152C File Offset: 0x0006F72C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 664223, RefRangeEnd = 664232, XrefRangeStart = 664221, XrefRangeEnd = 664223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsForListInternal(Type searchType, Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00071580 File Offset: 0x0006F780
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 664223, RefRangeEnd = 664232, XrefRangeStart = 664223, XrefRangeEnd = 664232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents(Type type, List<Component> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000715D4 File Offset: 0x0006F7D4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 664241, RefRangeEnd = 664253, XrefRangeStart = 664232, XrefRangeEnd = 664241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x000097E0 File Offset: 0x000079E0
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00071618 File Offset: 0x0006F818
		public unsafe string tag
		{
			get
			{
				return this.gameObject.tag;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 664258, RefRangeEnd = 664261, XrefRangeStart = 664253, XrefRangeEnd = 664258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0007165C File Offset: 0x0006F85C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 664268, RefRangeEnd = 664285, XrefRangeStart = 664261, XrefRangeEnd = 664268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponents<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00071694 File Offset: 0x0006F894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664285, XrefRangeEnd = 664287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, Object value, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000716F8 File Offset: 0x0006F8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 664289, RefRangeEnd = 664290, XrefRangeStart = 664287, XrefRangeEnd = 664289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00071748 File Offset: 0x0006F948
		[CallerCount(840)]
		[CachedScanResults(RefRangeStart = 660955, RefRangeEnd = 661795, XrefRangeStart = 660955, XrefRangeEnd = 661795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Component>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000097D7 File Offset: 0x000079D7
		public Component(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00071784 File Offset: 0x0006F984
		public Component GetComponent(string type)
		{
			IntPtr intPtr = Component.GetComponentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000717B8 File Offset: 0x0006F9B8
		public Component GetComponentInChildren(Type t)
		{
			return this.GetComponentInChildren(t, false);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000717D4 File Offset: 0x0006F9D4
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren(t, includeInactive);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000717F4 File Offset: 0x0006F9F4
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type t)
		{
			return this.gameObject.GetComponentsInChildren(t, false);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00071814 File Offset: 0x0006FA14
		public Component GetComponentInParent(Type t)
		{
			return this.gameObject.GetComponentInParent(t, false);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00071834 File Offset: 0x0006FA34
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent(t, includeInactive);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00071854 File Offset: 0x0006FA54
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type t)
		{
			return this.GetComponentsInParent(t, false);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00071870 File Offset: 0x0006FA70
		public Il2CppReferenceArray<Component> GetComponents(Type type)
		{
			return this.gameObject.GetComponents(type);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000097ED File Offset: 0x000079ED
		public int GetComponentIndex()
		{
			return Component.GetComponentIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00071890 File Offset: 0x0006FA90
		public bool CompareTag(string tag)
		{
			return this.gameObject.CompareTag(tag);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000097FF File Offset: 0x000079FF
		public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
		{
			Component.SendMessageUpwardsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(value), options);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0000981E File Offset: 0x00007A1E
		public void SendMessageUpwards(string methodName, Object value)
		{
			this.SendMessageUpwards(methodName, value, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0000982B File Offset: 0x00007A2B
		public void SendMessageUpwards(string methodName)
		{
			this.SendMessageUpwards(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00009838 File Offset: 0x00007A38
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00009845 File Offset: 0x00007A45
		public void SendMessage(string methodName, Object value)
		{
			this.SendMessage(methodName, value, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00009852 File Offset: 0x00007A52
		public void SendMessage(string methodName)
		{
			this.SendMessage(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0000985F File Offset: 0x00007A5F
		public void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
		{
			Component.BroadcastMessageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(parameter), options);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0000987E File Offset: 0x00007A7E
		public void BroadcastMessage(string methodName, Object parameter)
		{
			this.BroadcastMessage(methodName, parameter, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0000988B File Offset: 0x00007A8B
		public void BroadcastMessage(string methodName)
		{
			this.BroadcastMessage(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00009898 File Offset: 0x00007A98
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001592 RID: 5522
		private static readonly Component.GetComponentDelegate GetComponentDelegateField;

		// Token: 0x04001593 RID: 5523
		private static readonly Component.GetComponentIndexDelegate GetComponentIndexDelegateField;

		// Token: 0x04001594 RID: 5524
		private static readonly Component.SendMessageUpwardsDelegate SendMessageUpwardsDelegateField;

		// Token: 0x04001595 RID: 5525
		private static readonly Component.BroadcastMessageDelegate BroadcastMessageDelegateField;

		// Token: 0x02000728 RID: 1832
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x04002C36 RID: 11318
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000729 RID: 1833
		private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04002C37 RID: 11319
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200072A RID: 1834
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
		{
			// Token: 0x04002C38 RID: 11320
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200072B RID: 1835
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
		{
			// Token: 0x04002C39 RID: 11321
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200072C RID: 1836
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002C3A RID: 11322
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200072D RID: 1837
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002C3B RID: 11323
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200072E RID: 1838
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C3C RID: 11324
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200072F RID: 1839
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002C3D RID: 11325
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000730 RID: 1840
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>
		{
			// Token: 0x04002C3E RID: 11326
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000731 RID: 1841
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
		{
			// Token: 0x04002C3F RID: 11327
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000732 RID: 1842
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002C40 RID: 11328
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000733 RID: 1843
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002C41 RID: 11329
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000734 RID: 1844
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C42 RID: 11330
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000735 RID: 1845
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002C43 RID: 11331
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000736 RID: 1846
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C44 RID: 11332
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000737 RID: 1847
		// (Invoke) Token: 0x0600372F RID: 14127
		private delegate IntPtr GetComponentDelegate(IntPtr @this, IntPtr type);

		// Token: 0x02000738 RID: 1848
		// (Invoke) Token: 0x06003731 RID: 14129
		private delegate int GetComponentIndexDelegate(IntPtr @this);

		// Token: 0x02000739 RID: 1849
		// (Invoke) Token: 0x06003733 RID: 14131
		private delegate void SendMessageUpwardsDelegate(IntPtr @this, IntPtr methodName, IntPtr value, SendMessageOptions options);

		// Token: 0x0200073A RID: 1850
		// (Invoke) Token: 0x06003735 RID: 14133
		private delegate void BroadcastMessageDelegate(IntPtr @this, IntPtr methodName, IntPtr parameter, SendMessageOptions options);
	}
}
