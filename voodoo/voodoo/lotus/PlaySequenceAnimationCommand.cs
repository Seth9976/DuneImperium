using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus.sequences;

namespace lotus
{
	// Token: 0x0200005E RID: 94
	public class PlaySequenceAnimationCommand : Command
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x0001B8AC File Offset: 0x00019AAC
		// Note: this type is marked as 'beforefieldinit'.
		static PlaySequenceAnimationCommand()
		{
			Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PlaySequenceAnimationCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr);
			PlaySequenceAnimationCommand.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr, "sequence");
			PlaySequenceAnimationCommand.NativeMethodInfoPtr__ctor_Public_Void_IAnimationSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr, 100664032);
			PlaySequenceAnimationCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr, 100664033);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001B918 File Offset: 0x00019B18
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaySequenceAnimationCommand(IAnimationSequence sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand.NativeMethodInfoPtr__ctor_Public_Void_IAnimationSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001B964 File Offset: 0x00019B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111804, XrefRangeEnd = 1111809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaySequenceAnimationCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00004ADD File Offset: 0x00002CDD
		public PlaySequenceAnimationCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001B9B0 File Offset: 0x00019BB0
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00004AE6 File Offset: 0x00002CE6
		public unsafe IAnimationSequence sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAnimationSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAnimationSequence_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000E1 RID: 225
		[ObfuscatedName("lotus.PlaySequenceAnimationCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000BD3 RID: 3027 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaySequenceAnimationCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr);
				PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, 100664034);
				PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, 100664035);
				PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, 100664036);
				PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, 100664037);
				PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, 100664038);
				PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr, 100664039);
			}

			// Token: 0x06000BD4 RID: 3028 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySequenceAnimationCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BD5 RID: 3029 RVA: 0x00030020 File Offset: 0x0002E220
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x00030054 File Offset: 0x0002E254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111795, XrefRangeEnd = 1111799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00030090 File Offset: 0x0002E290
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x000300D0 File Offset: 0x0002E2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111799, XrefRangeEnd = 1111804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00030104 File Offset: 0x0002E304
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySequenceAnimationCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x00007CE4 File Offset: 0x00005EE4
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00030144 File Offset: 0x0002E344
			// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00007CED File Offset: 0x00005EED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0003016C File Offset: 0x0002E36C
			// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00007D08 File Offset: 0x00005F08
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0003019C File Offset: 0x0002E39C
			// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00007D27 File Offset: 0x00005F27
			public unsafe PlaySequenceAnimationCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaySequenceAnimationCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySequenceAnimationCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000763 RID: 1891
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000764 RID: 1892
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000765 RID: 1893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000766 RID: 1894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000767 RID: 1895
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000768 RID: 1896
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000769 RID: 1897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400076A RID: 1898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400076B RID: 1899
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
