using System;
using boardgames.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm
{
	// Token: 0x02000051 RID: 81
	public class WormLoadPlaymatManager : LoadPlaymatManager
	{
		// Token: 0x06000353 RID: 851 RVA: 0x000232BC File Offset: 0x000214BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormLoadPlaymatManager()
		{
			Il2CppClassPointerStore<WormLoadPlaymatManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormLoadPlaymatManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLoadPlaymatManager>.NativeClassPtr);
			WormLoadPlaymatManager.NativeMethodInfoPtr_OnLoadIntoPlaymat_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager>.NativeClassPtr, 100663837);
			WormLoadPlaymatManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager>.NativeClassPtr, 100663838);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00023314 File Offset: 0x00021514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691579, XrefRangeEnd = 691583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnLoadIntoPlaymat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLoadPlaymatManager.NativeMethodInfoPtr_OnLoadIntoPlaymat_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00023360 File Offset: 0x00021560
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLoadPlaymatManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLoadPlaymatManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003846 File Offset: 0x00001A46
		public WormLoadPlaymatManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadIntoPlaymat_Public_Virtual_IEnumerator_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E7 RID: 743
		[ObfuscatedName("worm.WormLoadPlaymatManager+<OnLoadIntoPlaymat>d__0")]
		public sealed class _OnLoadIntoPlaymat_d__0 : Object
		{
			// Token: 0x06001E36 RID: 7734 RVA: 0x00074AA0 File Offset: 0x00072CA0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnLoadIntoPlaymat_d__0()
			{
				Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLoadPlaymatManager>.NativeClassPtr, "<OnLoadIntoPlaymat>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr);
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, "<>1__state");
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, "<>2__current");
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, 100663839);
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, 100663840);
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, 100663841);
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, 100663842);
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, 100663843);
				WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr, 100663844);
			}

			// Token: 0x06001E37 RID: 7735 RVA: 0x00074B6C File Offset: 0x00072D6C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnLoadIntoPlaymat_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E38 RID: 7736 RVA: 0x00074BB4 File Offset: 0x00072DB4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E39 RID: 7737 RVA: 0x00074BE8 File Offset: 0x00072DE8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00074C24 File Offset: 0x00072E24
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x00074C64 File Offset: 0x00072E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691574, XrefRangeEnd = 691579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00074C98 File Offset: 0x00072E98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001E3D RID: 7741 RVA: 0x00011304 File Offset: 0x0000F504
			public _OnLoadIntoPlaymat_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00074CD8 File Offset: 0x00072ED8
			// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0001130D File Offset: 0x0000F50D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00074D00 File Offset: 0x00072F00
			// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00011328 File Offset: 0x0000F528
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLoadPlaymatManager._OnLoadIntoPlaymat_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001182 RID: 4482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001185 RID: 4485
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001186 RID: 4486
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001187 RID: 4487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001188 RID: 4488
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001189 RID: 4489
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
