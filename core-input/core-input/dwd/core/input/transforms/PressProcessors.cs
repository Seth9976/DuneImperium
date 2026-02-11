using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input.transforms
{
	// Token: 0x02000062 RID: 98
	public sealed class PressProcessors : global::Il2CppSystem.Object
	{
		// Token: 0x060003BE RID: 958 RVA: 0x000127AC File Offset: 0x000109AC
		// Note: this type is marked as 'beforefieldinit'.
		static PressProcessors()
		{
			Il2CppClassPointerStore<PressProcessors>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.transforms", "PressProcessors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr);
			PressProcessors.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, "factory");
			PressProcessors.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, "map");
			PressProcessors.NativeFieldInfoPtr_cleanupList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, "cleanupList");
			PressProcessors.NativeFieldInfoPtr_mapList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, "mapList");
			PressProcessors.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Transform_IPressProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, 100663715);
			PressProcessors.NativeMethodInfoPtr_Process_Public_Void_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, 100663716);
			PressProcessors.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, 100663717);
			PressProcessors.NativeMethodInfoPtr_cleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, 100663718);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0001287C File Offset: 0x00010A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1121978, RefRangeEnd = 1121980, XrefRangeStart = 1121951, XrefRangeEnd = 1121978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressProcessors(Func<Transform, IPressProcessor> factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Transform_IPressProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000128C8 File Offset: 0x00010AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121980, XrefRangeEnd = 1122005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process(PressEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.NativeMethodInfoPtr_Process_Public_Void_PressEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001290C File Offset: 0x00010B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122046, RefRangeEnd = 1122048, XrefRangeStart = 1122005, XrefRangeEnd = 1122046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0001294C File Offset: 0x00010B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122081, RefRangeEnd = 1122082, XrefRangeStart = 1122048, XrefRangeEnd = 1122081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.NativeMethodInfoPtr_cleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000042AD File Offset: 0x000024AD
		public PressProcessors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00012980 File Offset: 0x00010B80
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000042B6 File Offset: 0x000024B6
		public unsafe Func<Transform, IPressProcessor> factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, IPressProcessor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000129B0 File Offset: 0x00010BB0
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000042D5 File Offset: 0x000024D5
		public unsafe Dictionary<global::Il2CppSystem.Object, IPressProcessor> map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<global::Il2CppSystem.Object, IPressProcessor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000129E0 File Offset: 0x00010BE0
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x000042F4 File Offset: 0x000024F4
		public unsafe List<global::Il2CppSystem.Object> cleanupList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_cleanupList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_cleanupList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00012A10 File Offset: 0x00010C10
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00004313 File Offset: 0x00002513
		public unsafe List<KeyValuePair<global::Il2CppSystem.Object, IPressProcessor>> mapList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_mapList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<global::Il2CppSystem.Object, IPressProcessor>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressProcessors.NativeFieldInfoPtr_mapList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_cleanupList;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_mapList;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Transform_IPressProcessor_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_PressEvent_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_cleanUp_Private_Void_0;

		// Token: 0x020000C8 RID: 200
		public class ObjectReferenceComparer : global::Il2CppSystem.Object
		{
			// Token: 0x060008CD RID: 2253 RVA: 0x00023660 File Offset: 0x00021860
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectReferenceComparer()
			{
				Il2CppClassPointerStore<PressProcessors.ObjectReferenceComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PressProcessors>.NativeClassPtr, "ObjectReferenceComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressProcessors.ObjectReferenceComparer>.NativeClassPtr);
				PressProcessors.ObjectReferenceComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors.ObjectReferenceComparer>.NativeClassPtr, 100663719);
				PressProcessors.ObjectReferenceComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors.ObjectReferenceComparer>.NativeClassPtr, 100663720);
				PressProcessors.ObjectReferenceComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressProcessors.ObjectReferenceComparer>.NativeClassPtr, 100663721);
			}

			// Token: 0x060008CE RID: 2254 RVA: 0x000236C8 File Offset: 0x000218C8
			[CallerCount(0)]
			public unsafe virtual bool System_Collections_Generic_IEqualityComparer_System_Object__Equals(global::Il2CppSystem.Object x, global::Il2CppSystem.Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.ObjectReferenceComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008CF RID: 2255 RVA: 0x00023728 File Offset: 0x00021928
			[CallerCount(0)]
			public unsafe virtual int System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.ObjectReferenceComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x00023778 File Offset: 0x00021978
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectReferenceComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressProcessors.ObjectReferenceComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressProcessors.ObjectReferenceComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x0000699F File Offset: 0x00004B9F
			public ObjectReferenceComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000576 RID: 1398
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x04000577 RID: 1399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x04000578 RID: 1400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
