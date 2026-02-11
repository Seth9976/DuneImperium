using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.loader.loaders
{
	// Token: 0x02000199 RID: 409
	public class DefaultLoader : VersionedModel
	{
		// Token: 0x0600170E RID: 5902 RVA: 0x000703B0 File Offset: 0x0006E5B0
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultLoader()
		{
			Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "DefaultLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr);
			DefaultLoader.NativeMethodInfoPtr_createAssetName_Protected_AssetName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr, 100666840);
			DefaultLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr, 100666841);
			DefaultLoader.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr, 100666842);
			DefaultLoader.NativeMethodInfoPtr_LoadAndWait_Public_Abstract_Virtual_New_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr, 100666843);
			DefaultLoader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr, 100666844);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00070444 File Offset: 0x0006E644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878820, RefRangeEnd = 878821, XrefRangeStart = 878818, XrefRangeEnd = 878820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetName createAssetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader.NativeMethodInfoPtr_createAssetName_Protected_AssetName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AssetName(intPtr);
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0007048C File Offset: 0x0006E68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878827, RefRangeEnd = 878828, XrefRangeStart = 878821, XrefRangeEnd = 878827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x000704DC File Offset: 0x0006E6DC
		[CallerCount(0)]
		public unsafe virtual void Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultLoader.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_AssetName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00070530 File Offset: 0x0006E730
		[CallerCount(0)]
		public unsafe virtual IEnumerator LoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultLoader.NativeMethodInfoPtr_LoadAndWait_Public_Abstract_Virtual_New_IEnumerator_AssetName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00070590 File Offset: 0x0006E790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862016, RefRangeEnd = 862018, XrefRangeStart = 862016, XrefRangeEnd = 862018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0000A19A File Offset: 0x0000839A
		public DefaultLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_createAssetName_Protected_AssetName_String_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_AssetName_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_Abstract_Virtual_New_IEnumerator_AssetName_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200032F RID: 815
		public enum States
		{
			// Token: 0x0400194E RID: 6478
			UNINITIALIZED,
			// Token: 0x0400194F RID: 6479
			Loading,
			// Token: 0x04001950 RID: 6480
			Loaded,
			// Token: 0x04001951 RID: 6481
			Error
		}

		// Token: 0x02000330 RID: 816
		[ObfuscatedName("dwd.core.loader.loaders.DefaultLoader+<LoadAndWait>d__2")]
		public sealed class _LoadAndWait_d__2 : Object
		{
			// Token: 0x0600252E RID: 9518 RVA: 0x000A0410 File Offset: 0x0009E610
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__2()
			{
				Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultLoader>.NativeClassPtr, "<LoadAndWait>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr);
				DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, "<>1__state");
				DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, "<>2__current");
				DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, "<>4__this");
				DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, "assetName");
				DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, "<l>5__2");
				DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, 100666845);
				DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, 100666846);
				DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, 100666847);
				DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, 100666848);
				DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, 100666849);
				DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr, 100666850);
			}

			// Token: 0x0600252F RID: 9519 RVA: 0x000A0518 File Offset: 0x0009E718
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultLoader._LoadAndWait_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002530 RID: 9520 RVA: 0x000A0560 File Offset: 0x0009E760
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002531 RID: 9521 RVA: 0x000A0594 File Offset: 0x0009E794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878803, XrefRangeEnd = 878813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x06002532 RID: 9522 RVA: 0x000A05D0 File Offset: 0x0009E7D0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002533 RID: 9523 RVA: 0x000A0610 File Offset: 0x0009E810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878813, XrefRangeEnd = 878818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x06002534 RID: 9524 RVA: 0x000A0644 File Offset: 0x0009E844
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoader._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002535 RID: 9525 RVA: 0x00010BE0 File Offset: 0x0000EDE0
			public _LoadAndWait_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x06002536 RID: 9526 RVA: 0x000A0684 File Offset: 0x0009E884
			// (set) Token: 0x06002537 RID: 9527 RVA: 0x00010BE9 File Offset: 0x0000EDE9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x06002538 RID: 9528 RVA: 0x000A06AC File Offset: 0x0009E8AC
			// (set) Token: 0x06002539 RID: 9529 RVA: 0x00010C04 File Offset: 0x0000EE04
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x0600253A RID: 9530 RVA: 0x000A06DC File Offset: 0x0009E8DC
			// (set) Token: 0x0600253B RID: 9531 RVA: 0x00010C23 File Offset: 0x0000EE23
			public unsafe DefaultLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x0600253C RID: 9532 RVA: 0x000A070C File Offset: 0x0009E90C
			// (set) Token: 0x0600253D RID: 9533 RVA: 0x00010C42 File Offset: 0x0000EE42
			public unsafe string assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr_assetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr_assetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x0600253E RID: 9534 RVA: 0x000A0734 File Offset: 0x0009E934
			// (set) Token: 0x0600253F RID: 9535 RVA: 0x00010C61 File Offset: 0x0000EE61
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoader._LoadAndWait_d__2.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001952 RID: 6482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001953 RID: 6483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001954 RID: 6484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001955 RID: 6485
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001956 RID: 6486
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x04001957 RID: 6487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001958 RID: 6488
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001959 RID: 6489
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400195A RID: 6490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400195B RID: 6491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400195C RID: 6492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
