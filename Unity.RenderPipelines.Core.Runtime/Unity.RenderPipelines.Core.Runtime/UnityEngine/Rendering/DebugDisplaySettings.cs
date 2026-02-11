using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x0200005B RID: 91
	public class DebugDisplaySettings<T> : Object where T : new()
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x00025384 File Offset: 0x00023584
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettings()
		{
			Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugDisplaySettings`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr);
			DebugDisplaySettings<T>.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, "m_Settings");
			DebugDisplaySettings<T>.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, "s_Instance");
			DebugDisplaySettings<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664113);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664114);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664115);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664116);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_Add_Protected_TData_TData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664117);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_ForEach_Public_Virtual_Final_New_Void_Action_1_IDebugDisplaySettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664118);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664119);
			DebugDisplaySettings<T>.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664120);
			DebugDisplaySettings<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, 100664121);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000254CC File Offset: 0x000236CC
		public unsafe static T Instance
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 960835, RefRangeEnd = 960843, XrefRangeStart = 960809, XrefRangeEnd = 960835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettings<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000254FC File Offset: 0x000236FC
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960843, XrefRangeEnd = 960856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettings<T>.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00025544 File Offset: 0x00023744
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960856, XrefRangeEnd = 960874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettings<T>.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0002558C File Offset: 0x0002378C
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960874, XrefRangeEnd = 960892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettings<T>.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000255D4 File Offset: 0x000237D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 960895, RefRangeEnd = 960901, XrefRangeStart = 960892, XrefRangeEnd = 960895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TData Add<TData>(TData newData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TData).IsValueType)
				{
					TData tdata = newData;
					intPtr = ((tdata is string) ? IL2CPP.ManagedStringToIl2Cpp(tdata as string) : IL2CPP.Il2CppObjectBaseToPtr(tdata as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newData;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettings<TData>.MethodInfoStoreGeneric_Add_Protected_TData_TData_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TData>(intPtr2, false, true);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00025654 File Offset: 0x00023854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960901, XrefRangeEnd = 960915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ForEach(Action<IDebugDisplaySettingsData> onExecute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onExecute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettings<T>.NativeMethodInfoPtr_ForEach_Public_Virtual_Final_New_Void_Action_1_IDebugDisplaySettingsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00025698 File Offset: 0x00023898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 960936, RefRangeEnd = 960937, XrefRangeStart = 960915, XrefRangeEnd = 960936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettings<T>.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000256D4 File Offset: 0x000238D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960937, XrefRangeEnd = 960950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetScreenClearColor(ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettings<T>.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_New_Boolean_byref_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00025728 File Offset: 0x00023928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 960971, RefRangeEnd = 960972, XrefRangeStart = 960950, XrefRangeEnd = 960971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettings<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000047F2 File Offset: 0x000029F2
		public DebugDisplaySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00025764 File Offset: 0x00023964
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x000047FB File Offset: 0x000029FB
		public unsafe HashSet<IDebugDisplaySettingsData> m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettings<T>.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IDebugDisplaySettingsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettings<T>.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00025794 File Offset: 0x00023994
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x0000481A File Offset: 0x00002A1A
		public unsafe static Lazy<T> s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettings<T>.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettings<T>.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_Add_Protected_TData_TData_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_ForEach_Public_Virtual_Final_New_Void_Action_1_IDebugDisplaySettingsData_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_New_Boolean_byref_Color_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000186 RID: 390
		[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettings`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001650 RID: 5712 RVA: 0x00060A8C File Offset: 0x0005EC8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DebugDisplaySettings<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettings<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettings<T>.__c>.NativeClassPtr);
				DebugDisplaySettings<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettings<T>.__c>.NativeClassPtr, "<>9");
				DebugDisplaySettings<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>.__c>.NativeClassPtr, 100664124);
				DebugDisplaySettings<T>.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettings<T>.__c>.NativeClassPtr, 100664125);
			}

			// Token: 0x06001651 RID: 5713 RVA: 0x00060B30 File Offset: 0x0005ED30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettings<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettings<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001652 RID: 5714 RVA: 0x00060B6C File Offset: 0x0005ED6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960805, XrefRangeEnd = 960809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T __cctor_b__15_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettings<T>.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06001653 RID: 5715 RVA: 0x0000B386 File Offset: 0x00009586
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001654 RID: 5716 RVA: 0x00060BA8 File Offset: 0x0005EDA8
			// (set) Token: 0x06001655 RID: 5717 RVA: 0x0000B38F File Offset: 0x0000958F
			public unsafe static DebugDisplaySettings<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettings<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettings<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettings<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001046 RID: 4166
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001047 RID: 4167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001048 RID: 4168
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_0_Internal_T_0;
		}

		// Token: 0x02000187 RID: 391
		private sealed class MethodInfoStoreGeneric_Add_Protected_TData_TData_0
		{
			// Token: 0x04001049 RID: 4169
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DebugDisplaySettings<TData>.NativeMethodInfoPtr_Add_Protected_TData_TData_0, Il2CppClassPointerStore<DebugDisplaySettings<TData>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr)) }))));
		}
	}
}
