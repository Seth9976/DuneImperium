using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001C5 RID: 453
	public class TimedInputBlocker : MonoBehaviour
	{
		// Token: 0x060013D6 RID: 5078 RVA: 0x00054690 File Offset: 0x00052890
		// Note: this type is marked as 'beforefieldinit'.
		static TimedInputBlocker()
		{
			Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "TimedInputBlocker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr);
			TimedInputBlocker.NativeFieldInfoPtr_blockSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr, "blockSeconds");
			TimedInputBlocker.NativeMethodInfoPtr_Event_StartBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr, 100666023);
			TimedInputBlocker.NativeMethodInfoPtr_Wait_Private_Static_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr, 100666024);
			TimedInputBlocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr, 100666025);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00054710 File Offset: 0x00052910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713443, XrefRangeEnd = 713452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_StartBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker.NativeMethodInfoPtr_Event_StartBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00054744 File Offset: 0x00052944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713452, XrefRangeEnd = 713456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Wait(float seconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker.NativeMethodInfoPtr_Wait_Private_Static_IEnumerator_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00054784 File Offset: 0x00052984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713456, XrefRangeEnd = 713457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedInputBlocker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000C2E7 File Offset: 0x0000A4E7
		public TimedInputBlocker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x000547C0 File Offset: 0x000529C0
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		public unsafe float blockSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker.NativeFieldInfoPtr_blockSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker.NativeFieldInfoPtr_blockSeconds)) = value;
			}
		}

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeFieldInfoPtr_blockSeconds;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_Event_StartBlock_Public_Void_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Private_Static_IEnumerator_Single_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CE RID: 974
		[ObfuscatedName("worm.match.components.TimedInputBlocker+<Wait>d__2")]
		public sealed class _Wait_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x0600276F RID: 10095 RVA: 0x0008FC28 File Offset: 0x0008DE28
			// Note: this type is marked as 'beforefieldinit'.
			static _Wait_d__2()
			{
				Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimedInputBlocker>.NativeClassPtr, "<Wait>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr);
				TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, "<>1__state");
				TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, "<>2__current");
				TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, "seconds");
				TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, 100666026);
				TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, 100666027);
				TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, 100666028);
				TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, 100666029);
				TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, 100666030);
				TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr, 100666031);
			}

			// Token: 0x06002770 RID: 10096 RVA: 0x0008FD08 File Offset: 0x0008DF08
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Wait_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedInputBlocker._Wait_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002771 RID: 10097 RVA: 0x0008FD50 File Offset: 0x0008DF50
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002772 RID: 10098 RVA: 0x0008FD84 File Offset: 0x0008DF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713433, XrefRangeEnd = 713438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06002773 RID: 10099 RVA: 0x0008FDC0 File Offset: 0x0008DFC0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002774 RID: 10100 RVA: 0x0008FE00 File Offset: 0x0008E000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713438, XrefRangeEnd = 713443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06002775 RID: 10101 RVA: 0x0008FE34 File Offset: 0x0008E034
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedInputBlocker._Wait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002776 RID: 10102 RVA: 0x00015ADB File Offset: 0x00013CDB
			public _Wait_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06002777 RID: 10103 RVA: 0x0008FE74 File Offset: 0x0008E074
			// (set) Token: 0x06002778 RID: 10104 RVA: 0x00015AE4 File Offset: 0x00013CE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x06002779 RID: 10105 RVA: 0x0008FE9C File Offset: 0x0008E09C
			// (set) Token: 0x0600277A RID: 10106 RVA: 0x00015AFF File Offset: 0x00013CFF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x0600277B RID: 10107 RVA: 0x0008FECC File Offset: 0x0008E0CC
			// (set) Token: 0x0600277C RID: 10108 RVA: 0x00015B1E File Offset: 0x00013D1E
			public unsafe float seconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr_seconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedInputBlocker._Wait_d__2.NativeFieldInfoPtr_seconds)) = value;
				}
			}

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeFieldInfoPtr_seconds;

			// Token: 0x040016B9 RID: 5817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016BA RID: 5818
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016BB RID: 5819
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016BC RID: 5820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016BD RID: 5821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016BE RID: 5822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
