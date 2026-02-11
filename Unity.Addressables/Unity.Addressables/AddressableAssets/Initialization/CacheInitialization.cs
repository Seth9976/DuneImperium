using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets.Initialization
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public class CacheInitialization : Object
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00011B84 File Offset: 0x0000FD84
		// Note: this type is marked as 'beforefieldinit'.
		static CacheInitialization()
		{
			Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Initialization", "CacheInitialization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr);
			CacheInitialization.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr, 100663887);
			CacheInitialization.NativeMethodInfoPtr_InitializeAsync_Public_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr, 100663888);
			CacheInitialization.NativeMethodInfoPtr_get_RootPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr, 100663889);
			CacheInitialization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr, 100663890);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00011C04 File Offset: 0x0000FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164699, XrefRangeEnd = 1164718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Initialize(string id, string dataStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dataStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00011C64 File Offset: 0x0000FE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164718, XrefRangeEnd = 1164741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CacheInitialization.NativeMethodInfoPtr_InitializeAsync_Public_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00011CDC File Offset: 0x0000FEDC
		public unsafe static string RootPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164741, XrefRangeEnd = 1164747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.NativeMethodInfoPtr_get_RootPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00011D08 File Offset: 0x0000FF08
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CacheInitialization()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002FD2 File Offset: 0x000011D2
		public CacheInitialization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_String_String_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_RootPath_Public_Static_get_String_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000080 RID: 128
		public class CacheInitOp : AsyncOperationBase<bool>
		{
			// Token: 0x06000566 RID: 1382 RVA: 0x00019268 File Offset: 0x00017468
			// Note: this type is marked as 'beforefieldinit'.
			static CacheInitOp()
			{
				Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr, "CacheInitOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr);
				CacheInitialization.CacheInitOp.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, "m_Callback");
				CacheInitialization.CacheInitOp.NativeFieldInfoPtr_m_UpdateRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, "m_UpdateRequired");
				CacheInitialization.CacheInitOp.NativeMethodInfoPtr_Init_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, 100663891);
				CacheInitialization.CacheInitOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, 100663892);
				CacheInitialization.CacheInitOp.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, 100663893);
				CacheInitialization.CacheInitOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, 100663894);
				CacheInitialization.CacheInitOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr, 100663895);
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00019320 File Offset: 0x00017520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Func<bool> callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.CacheInitOp.NativeMethodInfoPtr_Init_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x00019364 File Offset: 0x00017564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164658, XrefRangeEnd = 1164668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CacheInitialization.CacheInitOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000569 RID: 1385 RVA: 0x000193AC File Offset: 0x000175AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164668, XrefRangeEnd = 1164674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Update(float unscaledDeltaTime)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref unscaledDeltaTime;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.CacheInitOp.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x000193EC File Offset: 0x000175EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164674, XrefRangeEnd = 1164677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CacheInitialization.CacheInitOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x00019428 File Offset: 0x00017628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164677, XrefRangeEnd = 1164680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CacheInitOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheInitialization.CacheInitOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.CacheInitOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600056C RID: 1388 RVA: 0x0000448D File Offset: 0x0000268D
			public CacheInitOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x0600056D RID: 1389 RVA: 0x00019464 File Offset: 0x00017664
			// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004496 File Offset: 0x00002696
			public unsafe Func<bool> m_Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.CacheInitOp.NativeFieldInfoPtr_m_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.CacheInitOp.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x0600056F RID: 1391 RVA: 0x00019494 File Offset: 0x00017694
			// (set) Token: 0x06000570 RID: 1392 RVA: 0x000044B5 File Offset: 0x000026B5
			public unsafe bool m_UpdateRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.CacheInitOp.NativeFieldInfoPtr_m_UpdateRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.CacheInitOp.NativeFieldInfoPtr_m_UpdateRequired)) = value;
				}
			}

			// Token: 0x040003C3 RID: 963
			private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

			// Token: 0x040003C4 RID: 964
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRequired;

			// Token: 0x040003C5 RID: 965
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Func_1_Boolean_0;

			// Token: 0x040003C6 RID: 966
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040003C7 RID: 967
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_Single_0;

			// Token: 0x040003C8 RID: 968
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040003C9 RID: 969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000081 RID: 129
		[ObfuscatedName("UnityEngine.AddressableAssets.Initialization.CacheInitialization+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06000571 RID: 1393 RVA: 0x000194BC File Offset: 0x000176BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CacheInitialization>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr);
				CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr, "id");
				CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr, "data");
				CacheInitialization.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr, 100663896);
				CacheInitialization.__c__DisplayClass1_0.NativeMethodInfoPtr__InitializeAsync_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr, 100663897);
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x0001954C File Offset: 0x0001774C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheInitialization.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x00019588 File Offset: 0x00017788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164680, XrefRangeEnd = 1164699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitialization.__c__DisplayClass1_0.NativeMethodInfoPtr__InitializeAsync_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x000044D0 File Offset: 0x000026D0
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x000195C4 File Offset: 0x000177C4
			// (set) Token: 0x06000576 RID: 1398 RVA: 0x000044D9 File Offset: 0x000026D9
			public unsafe CacheInitialization __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CacheInitialization>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000577 RID: 1399 RVA: 0x000195F4 File Offset: 0x000177F4
			// (set) Token: 0x06000578 RID: 1400 RVA: 0x000044F8 File Offset: 0x000026F8
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001961C File Offset: 0x0001781C
			// (set) Token: 0x0600057A RID: 1402 RVA: 0x00004517 File Offset: 0x00002717
			public unsafe string data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr_data);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitialization.__c__DisplayClass1_0.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040003CA RID: 970
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003CB RID: 971
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040003CC RID: 972
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040003CD RID: 973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003CE RID: 974
			private static readonly IntPtr NativeMethodInfoPtr__InitializeAsync_b__0_Internal_Boolean_0;
		}
	}
}
