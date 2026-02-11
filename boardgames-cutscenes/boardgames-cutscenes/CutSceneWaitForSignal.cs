using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x02000013 RID: 19
	public class CutSceneWaitForSignal : CutSceneAction
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x000050D8 File Offset: 0x000032D8
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneWaitForSignal()
		{
			Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneWaitForSignal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr);
			CutSceneWaitForSignal.NativeFieldInfoPtr_signalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr, "signalName");
			CutSceneWaitForSignal.NativeMethodInfoPtr_Play_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr, 100663436);
			CutSceneWaitForSignal.NativeMethodInfoPtr_play_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr, 100663437);
			CutSceneWaitForSignal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr, 100663438);
			CutSceneWaitForSignal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr, 100663439);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000516C File Offset: 0x0000336C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258500, XrefRangeEnd = 1258509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneWaitForSignal.NativeMethodInfoPtr_Play_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000051B8 File Offset: 0x000033B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258509, XrefRangeEnd = 1258514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal.NativeMethodInfoPtr_play_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000051F8 File Offset: 0x000033F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258514, XrefRangeEnd = 1258517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneWaitForSignal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000523C File Offset: 0x0000343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneWaitForSignal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002437 File Offset: 0x00000637
		public CutSceneWaitForSignal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00005278 File Offset: 0x00003478
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002440 File Offset: 0x00000640
		public unsafe string signalName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal.NativeFieldInfoPtr_signalName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal.NativeFieldInfoPtr_signalName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_signalName;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_play_Private_IEnumerator_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002C RID: 44
		[ObfuscatedName("lotus.CutSceneWaitForSignal+<play>d__2")]
		public sealed class _play_d__2 : Object
		{
			// Token: 0x060001B6 RID: 438 RVA: 0x000085B8 File Offset: 0x000067B8
			// Note: this type is marked as 'beforefieldinit'.
			static _play_d__2()
			{
				Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutSceneWaitForSignal>.NativeClassPtr, "<play>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr);
				CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, "<>1__state");
				CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, "<>2__current");
				CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, "<>4__this");
				CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, 100663440);
				CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, 100663441);
				CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, 100663442);
				CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, 100663443);
				CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, 100663444);
				CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr, 100663445);
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00008698 File Offset: 0x00006898
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _play_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneWaitForSignal._play_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x000086E0 File Offset: 0x000068E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00008714 File Offset: 0x00006914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258490, XrefRangeEnd = 1258495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001BA RID: 442 RVA: 0x00008750 File Offset: 0x00006950
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00008790 File Offset: 0x00006990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258495, XrefRangeEnd = 1258500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001BC RID: 444 RVA: 0x000087C4 File Offset: 0x000069C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneWaitForSignal._play_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00002C12 File Offset: 0x00000E12
			public _play_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001BE RID: 446 RVA: 0x00008804 File Offset: 0x00006A04
			// (set) Token: 0x060001BF RID: 447 RVA: 0x00002C1B File Offset: 0x00000E1B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000882C File Offset: 0x00006A2C
			// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002C36 File Offset: 0x00000E36
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000885C File Offset: 0x00006A5C
			// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002C55 File Offset: 0x00000E55
			public unsafe CutSceneWaitForSignal __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneWaitForSignal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneWaitForSignal._play_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
