using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000BB RID: 187
	public class LocalizationGroupOperation : GroupOperation
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x0002EFE4 File Offset: 0x0002D1E4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationGroupOperation()
		{
			Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "LocalizationGroupOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr);
			LocalizationGroupOperation.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr, "Pool");
			LocalizationGroupOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr, 100664987);
			LocalizationGroupOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr, 100664988);
			LocalizationGroupOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr, 100664989);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002F064 File Offset: 0x0002D264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078179, XrefRangeEnd = 1078201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationGroupOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078201, XrefRangeEnd = 1078210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationGroupOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078210, XrefRangeEnd = 1078211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationGroupOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationGroupOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00006031 File Offset: 0x00004231
		public LocalizationGroupOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002F124 File Offset: 0x0002D324
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0000603A File Offset: 0x0000423A
		public unsafe static ObjectPool<LocalizationGroupOperation> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizationGroupOperation.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LocalizationGroupOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationGroupOperation.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000170 RID: 368
		[ObfuscatedName("UnityEngine.Localization.Operations.LocalizationGroupOperation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F8A RID: 3978 RVA: 0x000425E8 File Offset: 0x000407E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalizationGroupOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationGroupOperation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationGroupOperation.__c>.NativeClassPtr);
				LocalizationGroupOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationGroupOperation.__c>.NativeClassPtr, "<>9");
				LocalizationGroupOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationGroupOperation.__c>.NativeClassPtr, 100664992);
				LocalizationGroupOperation.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_LocalizationGroupOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationGroupOperation.__c>.NativeClassPtr, 100664993);
			}

			// Token: 0x06000F8B RID: 3979 RVA: 0x00042650 File Offset: 0x00040850
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationGroupOperation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationGroupOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F8C RID: 3980 RVA: 0x0004268C File Offset: 0x0004088C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078175, XrefRangeEnd = 1078179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LocalizationGroupOperation __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationGroupOperation.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_LocalizationGroupOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizationGroupOperation>(intPtr3) : null;
			}

			// Token: 0x06000F8D RID: 3981 RVA: 0x00008789 File Offset: 0x00006989
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000F8E RID: 3982 RVA: 0x000426CC File Offset: 0x000408CC
			// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00008792 File Offset: 0x00006992
			public unsafe static LocalizationGroupOperation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizationGroupOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationGroupOperation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizationGroupOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AAF RID: 2735
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AB0 RID: 2736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AB1 RID: 2737
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_LocalizationGroupOperation_0;
		}
	}
}
