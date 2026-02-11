using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200024B RID: 587
	public class WormGainInfluenceSequence : VoodooGroupedSequence
	{
		// Token: 0x060018F5 RID: 6389 RVA: 0x00063FFC File Offset: 0x000621FC
		// Note: this type is marked as 'beforefieldinit'.
		static WormGainInfluenceSequence()
		{
			Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormGainInfluenceSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr);
			WormGainInfluenceSequence.NativeFieldInfoPtr_PlayerColorParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr, "PlayerColorParam");
			WormGainInfluenceSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr, 100666836);
			WormGainInfluenceSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr, 100666837);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00064068 File Offset: 0x00062268
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGainInfluenceSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000640D8 File Offset: 0x000622D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719628, XrefRangeEnd = 719633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PreSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGainInfluenceSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0000EB95 File Offset: 0x0000CD95
		public WormGainInfluenceSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00064124 File Offset: 0x00062324
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x0000EB9E File Offset: 0x0000CD9E
		public unsafe static int PlayerColorParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormGainInfluenceSequence.NativeFieldInfoPtr_PlayerColorParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGainInfluenceSequence.NativeFieldInfoPtr_PlayerColorParam, (void*)(&value));
			}
		}

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeFieldInfoPtr_PlayerColorParam;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_PreSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000418 RID: 1048
		[ObfuscatedName("worm.match.commands.sequenceCommands.WormGainInfluenceSequence+<PreSequence>d__2")]
		public sealed class _PreSequence_d__2 : Object
		{
			// Token: 0x06002B44 RID: 11076 RVA: 0x0009B1D0 File Offset: 0x000993D0
			// Note: this type is marked as 'beforefieldinit'.
			static _PreSequence_d__2()
			{
				Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGainInfluenceSequence>.NativeClassPtr, "<PreSequence>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr);
				WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, "<>1__state");
				WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, "<>2__current");
				WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, "<>4__this");
				WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, 100666839);
				WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, 100666840);
				WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, 100666841);
				WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, 100666842);
				WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, 100666843);
				WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr, 100666844);
			}

			// Token: 0x06002B45 RID: 11077 RVA: 0x0009B2B0 File Offset: 0x000994B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreSequence_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGainInfluenceSequence._PreSequence_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B46 RID: 11078 RVA: 0x0009B2F8 File Offset: 0x000994F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B47 RID: 11079 RVA: 0x0009B32C File Offset: 0x0009952C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719488, XrefRangeEnd = 719623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x06002B48 RID: 11080 RVA: 0x0009B368 File Offset: 0x00099568
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B49 RID: 11081 RVA: 0x0009B3A8 File Offset: 0x000995A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719623, XrefRangeEnd = 719628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x06002B4A RID: 11082 RVA: 0x0009B3DC File Offset: 0x000995DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceSequence._PreSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B4B RID: 11083 RVA: 0x000179C0 File Offset: 0x00015BC0
			public _PreSequence_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C55 RID: 3157
			// (get) Token: 0x06002B4C RID: 11084 RVA: 0x0009B41C File Offset: 0x0009961C
			// (set) Token: 0x06002B4D RID: 11085 RVA: 0x000179C9 File Offset: 0x00015BC9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C56 RID: 3158
			// (get) Token: 0x06002B4E RID: 11086 RVA: 0x0009B444 File Offset: 0x00099644
			// (set) Token: 0x06002B4F RID: 11087 RVA: 0x000179E4 File Offset: 0x00015BE4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x06002B50 RID: 11088 RVA: 0x0009B474 File Offset: 0x00099674
			// (set) Token: 0x06002B51 RID: 11089 RVA: 0x00017A03 File Offset: 0x00015C03
			public unsafe WormGainInfluenceSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGainInfluenceSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceSequence._PreSequence_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400191F RID: 6431
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001920 RID: 6432
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001921 RID: 6433
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001922 RID: 6434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001923 RID: 6435
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001924 RID: 6436
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001925 RID: 6437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001926 RID: 6438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001927 RID: 6439
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
