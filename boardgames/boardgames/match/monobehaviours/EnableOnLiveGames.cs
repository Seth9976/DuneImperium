using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.match.monobehaviours
{
	// Token: 0x0200012D RID: 301
	public class EnableOnLiveGames : MonoBehaviour
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x00040EB8 File Offset: 0x0003F0B8
		// Note: this type is marked as 'beforefieldinit'.
		static EnableOnLiveGames()
		{
			Il2CppClassPointerStore<EnableOnLiveGames>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.monobehaviours", "EnableOnLiveGames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableOnLiveGames>.NativeClassPtr);
			EnableOnLiveGames.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames>.NativeClassPtr, 100665536);
			EnableOnLiveGames.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames>.NativeClassPtr, 100665537);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00040F10 File Offset: 0x0003F110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998135, XrefRangeEnd = 998140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00040F50 File Offset: 0x0003F150
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnableOnLiveGames()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableOnLiveGames>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000094D8 File Offset: 0x000076D8
		public EnableOnLiveGames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000264 RID: 612
		[ObfuscatedName("boardgames.match.monobehaviours.EnableOnLiveGames+<Start>d__0")]
		public sealed class _Start_d__0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001C0A RID: 7178 RVA: 0x00067878 File Offset: 0x00065A78
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__0()
			{
				Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnableOnLiveGames>.NativeClassPtr, "<Start>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr);
				EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, "<>1__state");
				EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, "<>2__current");
				EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, "<>4__this");
				EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, 100665538);
				EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, 100665539);
				EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, 100665540);
				EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, 100665541);
				EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, 100665542);
				EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr, 100665543);
			}

			// Token: 0x06001C0B RID: 7179 RVA: 0x00067958 File Offset: 0x00065B58
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableOnLiveGames._Start_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x000679A0 File Offset: 0x00065BA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x000679D4 File Offset: 0x00065BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998126, XrefRangeEnd = 998130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00067A10 File Offset: 0x00065C10
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C0F RID: 7183 RVA: 0x00067A50 File Offset: 0x00065C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998130, XrefRangeEnd = 998135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00067A84 File Offset: 0x00065C84
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableOnLiveGames._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C11 RID: 7185 RVA: 0x0000F280 File Offset: 0x0000D480
			public _Start_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00067AC4 File Offset: 0x00065CC4
			// (set) Token: 0x06001C13 RID: 7187 RVA: 0x0000F289 File Offset: 0x0000D489
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00067AEC File Offset: 0x00065CEC
			// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00067B1C File Offset: 0x00065D1C
			// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000F2C3 File Offset: 0x0000D4C3
			public unsafe EnableOnLiveGames __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnableOnLiveGames>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableOnLiveGames._Start_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400110B RID: 4363
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400110C RID: 4364
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400110D RID: 4365
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400110E RID: 4366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400110F RID: 4367
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001110 RID: 4368
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001111 RID: 4369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001112 RID: 4370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001113 RID: 4371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
