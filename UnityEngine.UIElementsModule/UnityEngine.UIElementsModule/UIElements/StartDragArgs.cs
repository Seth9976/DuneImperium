using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AF RID: 175
	public sealed class StartDragArgs : ValueType
	{
		// Token: 0x0600108D RID: 4237 RVA: 0x00057148 File Offset: 0x00055348
		// Note: this type is marked as 'beforefieldinit'.
		static StartDragArgs()
		{
			Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StartDragArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr);
			StartDragArgs.NativeFieldInfoPtr__title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, "<title>k__BackingField");
			StartDragArgs.NativeFieldInfoPtr__visualMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, "<visualMode>k__BackingField");
			StartDragArgs.NativeFieldInfoPtr__genericData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, "<genericData>k__BackingField");
			StartDragArgs.NativeFieldInfoPtr__unityObjectReferences_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, "<unityObjectReferences>k__BackingField");
			StartDragArgs.NativeMethodInfoPtr__ctor_Public_Void_String_DragVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665663);
			StartDragArgs.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665664);
			StartDragArgs.NativeMethodInfoPtr_get_visualMode_Public_get_DragVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665665);
			StartDragArgs.NativeMethodInfoPtr_get_genericData_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665666);
			StartDragArgs.NativeMethodInfoPtr_set_genericData_Private_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665667);
			StartDragArgs.NativeMethodInfoPtr_get_unityObjectReferences_Internal_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665668);
			StartDragArgs.NativeMethodInfoPtr_set_unityObjectReferences_Private_set_Void_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665669);
			StartDragArgs.NativeMethodInfoPtr_SetGenericData_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, 100665670);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00057268 File Offset: 0x00055468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310363, XrefRangeEnd = 310366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartDragArgs(string title, DragVisualMode visualMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr__ctor_Public_Void_String_DragVisualMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000572C8 File Offset: 0x000554C8
		public unsafe string title
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00057304 File Offset: 0x00055504
		public unsafe DragVisualMode visualMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_get_visualMode_Public_get_DragVisualMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00057348 File Offset: 0x00055548
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0005738C File Offset: 0x0005558C
		public unsafe Hashtable genericData
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_get_genericData_Internal_get_Hashtable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_set_genericData_Private_set_Void_Hashtable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000573D4 File Offset: 0x000555D4
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00057418 File Offset: 0x00055618
		public unsafe IEnumerable<Object> unityObjectReferences
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_get_unityObjectReferences_Internal_get_IEnumerable_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_set_unityObjectReferences_Private_set_Void_IEnumerable_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00057460 File Offset: 0x00055660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310366, XrefRangeEnd = 310372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGenericData(string key, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartDragArgs.NativeMethodInfoPtr_SetGenericData_Public_Void_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0000854E File Offset: 0x0000674E
		public StartDragArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00008557 File Offset: 0x00006757
		public StartDragArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x000574BC File Offset: 0x000556BC
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00008569 File Offset: 0x00006769
		public unsafe string _title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x000574E4 File Offset: 0x000556E4
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00008588 File Offset: 0x00006788
		public unsafe DragVisualMode _visualMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__visualMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__visualMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0005750C File Offset: 0x0005570C
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x000085A3 File Offset: 0x000067A3
		public unsafe Hashtable _genericData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__genericData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__genericData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0005753C File Offset: 0x0005573C
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x000085C2 File Offset: 0x000067C2
		public unsafe IEnumerable<Object> _unityObjectReferences_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__unityObjectReferences_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartDragArgs.NativeFieldInfoPtr__unityObjectReferences_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000085E1 File Offset: 0x000067E1
		public void SetUnityObjectReferences(IEnumerable<Object> references)
		{
			this.unityObjectReferences = references;
		}

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr__title_k__BackingField;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr__visualMode_k__BackingField;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr__genericData_k__BackingField;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr__unityObjectReferences_k__BackingField;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DragVisualMode_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_visualMode_Public_get_DragVisualMode_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_get_genericData_Internal_get_Hashtable_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_set_genericData_Private_set_Void_Hashtable_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectReferences_Internal_get_IEnumerable_1_Object_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_set_unityObjectReferences_Private_set_Void_IEnumerable_1_Object_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_SetGenericData_Public_Void_String_Object_0;
	}
}
