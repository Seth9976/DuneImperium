using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.audio.commands
{
	// Token: 0x02000210 RID: 528
	public class DefaultPlayAudioCommand : PlayAudioCommand
	{
		// Token: 0x06001CF7 RID: 7415 RVA: 0x00086898 File Offset: 0x00084A98
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultPlayAudioCommand()
		{
			Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.audio.commands", "DefaultPlayAudioCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr);
			DefaultPlayAudioCommand.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, "sound");
			DefaultPlayAudioCommand.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, "worldPosition");
			DefaultPlayAudioCommand.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, "parent");
			DefaultPlayAudioCommand.NativeFieldInfoPtr_playAtWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, "playAtWorldPosition");
			DefaultPlayAudioCommand.NativeMethodInfoPtr__ctor_Public_Void_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, 100667968);
			DefaultPlayAudioCommand.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, 100667969);
			DefaultPlayAudioCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, 100667970);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00086954 File Offset: 0x00084B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886138, XrefRangeEnd = 886141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultPlayAudioCommand(string sound, Transform parent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand.NativeMethodInfoPtr__ctor_Public_Void_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000869B4 File Offset: 0x00084BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886141, XrefRangeEnd = 886144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultPlayAudioCommand(string sound, Vector3 worldPosition, Transform parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00086A20 File Offset: 0x00084C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886144, XrefRangeEnd = 886149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultPlayAudioCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0000C5B2 File Offset: 0x0000A7B2
		public DefaultPlayAudioCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00086A6C File Offset: 0x00084C6C
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000C5BB File Offset: 0x0000A7BB
		public unsafe string sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_sound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_sound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00086A94 File Offset: 0x00084C94
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000C5DA File Offset: 0x0000A7DA
		public unsafe Vector3 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00086ABC File Offset: 0x00084CBC
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000C5F5 File Offset: 0x0000A7F5
		public unsafe Transform parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00086AEC File Offset: 0x00084CEC
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0000C614 File Offset: 0x0000A814
		public unsafe bool playAtWorldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_playAtWorldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand.NativeFieldInfoPtr_playAtWorldPosition)) = value;
			}
		}

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_sound;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_playAtWorldPosition;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Transform_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Transform_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020003A0 RID: 928
		[ObfuscatedName("dwd.core.audio.commands.DefaultPlayAudioCommand+<execute>d__6")]
		public sealed class _execute_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06002958 RID: 10584 RVA: 0x000AD7A8 File Offset: 0x000AB9A8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultPlayAudioCommand>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr);
				DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, "<>1__state");
				DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, "<>2__current");
				DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, "<>4__this");
				DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, 100667971);
				DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, 100667972);
				DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, 100667973);
				DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, 100667974);
				DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, 100667975);
				DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr, 100667976);
			}

			// Token: 0x06002959 RID: 10585 RVA: 0x000AD888 File Offset: 0x000ABA88
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultPlayAudioCommand._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600295A RID: 10586 RVA: 0x000AD8D0 File Offset: 0x000ABAD0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600295B RID: 10587 RVA: 0x000AD904 File Offset: 0x000ABB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886109, XrefRangeEnd = 886133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x0600295C RID: 10588 RVA: 0x000AD940 File Offset: 0x000ABB40
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600295D RID: 10589 RVA: 0x000AD980 File Offset: 0x000ABB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886133, XrefRangeEnd = 886138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x0600295E RID: 10590 RVA: 0x000AD9B4 File Offset: 0x000ABBB4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPlayAudioCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600295F RID: 10591 RVA: 0x00012CA7 File Offset: 0x00010EA7
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BBB RID: 3003
			// (get) Token: 0x06002960 RID: 10592 RVA: 0x000AD9F4 File Offset: 0x000ABBF4
			// (set) Token: 0x06002961 RID: 10593 RVA: 0x00012CB0 File Offset: 0x00010EB0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BBC RID: 3004
			// (get) Token: 0x06002962 RID: 10594 RVA: 0x000ADA1C File Offset: 0x000ABC1C
			// (set) Token: 0x06002963 RID: 10595 RVA: 0x00012CCB File Offset: 0x00010ECB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x06002964 RID: 10596 RVA: 0x000ADA4C File Offset: 0x000ABC4C
			// (set) Token: 0x06002965 RID: 10597 RVA: 0x00012CEA File Offset: 0x00010EEA
			public unsafe DefaultPlayAudioCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPlayAudioCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultPlayAudioCommand._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BF7 RID: 7159
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BF8 RID: 7160
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BF9 RID: 7161
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BFA RID: 7162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BFB RID: 7163
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BFC RID: 7164
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BFD RID: 7165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BFE RID: 7166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BFF RID: 7167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
