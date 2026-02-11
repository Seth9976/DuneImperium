using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x0200028C RID: 652
	public class FastForwardGameQueueCommand : Command
	{
		// Token: 0x06001EA6 RID: 7846 RVA: 0x00083988 File Offset: 0x00081B88
		// Note: this type is marked as 'beforefieldinit'.
		static FastForwardGameQueueCommand()
		{
			Il2CppClassPointerStore<FastForwardGameQueueCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "FastForwardGameQueueCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastForwardGameQueueCommand>.NativeClassPtr);
			FastForwardGameQueueCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand>.NativeClassPtr, 100668331);
			FastForwardGameQueueCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand>.NativeClassPtr, 100668332);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000839E0 File Offset: 0x00081BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539444, XrefRangeEnd = 539448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FastForwardGameQueueCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00083A2C File Offset: 0x00081C2C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastForwardGameQueueCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastForwardGameQueueCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000102DE File Offset: 0x0000E4DE
		public FastForwardGameQueueCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000480 RID: 1152
		[ObfuscatedName("boardgames.match.commands.FastForwardGameQueueCommand+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06003677 RID: 13943 RVA: 0x000CB2DC File Offset: 0x000C94DC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FastForwardGameQueueCommand>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr);
				FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, "<>1__state");
				FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, "<>2__current");
				FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr__originalFrameRate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, "<originalFrameRate>5__2");
				FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr__originalFixedDeltaTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, "<originalFixedDeltaTime>5__3");
				FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, 100668333);
				FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, 100668334);
				FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, 100668335);
				FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, 100668336);
				FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, 100668337);
				FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr, 100668338);
			}

			// Token: 0x06003678 RID: 13944 RVA: 0x000CB3D0 File Offset: 0x000C95D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastForwardGameQueueCommand._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003679 RID: 13945 RVA: 0x000CB418 File Offset: 0x000C9618
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600367A RID: 13946 RVA: 0x000CB44C File Offset: 0x000C964C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539416, XrefRangeEnd = 539439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001003 RID: 4099
			// (get) Token: 0x0600367B RID: 13947 RVA: 0x000CB488 File Offset: 0x000C9688
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600367C RID: 13948 RVA: 0x000CB4C8 File Offset: 0x000C96C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539439, XrefRangeEnd = 539444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001004 RID: 4100
			// (get) Token: 0x0600367D RID: 13949 RVA: 0x000CB4FC File Offset: 0x000C96FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastForwardGameQueueCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600367E RID: 13950 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FFF RID: 4095
			// (get) Token: 0x0600367F RID: 13951 RVA: 0x000CB53C File Offset: 0x000C973C
			// (set) Token: 0x06003680 RID: 13952 RVA: 0x0001C0BD File Offset: 0x0001A2BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001000 RID: 4096
			// (get) Token: 0x06003681 RID: 13953 RVA: 0x000CB564 File Offset: 0x000C9764
			// (set) Token: 0x06003682 RID: 13954 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001001 RID: 4097
			// (get) Token: 0x06003683 RID: 13955 RVA: 0x000CB594 File Offset: 0x000C9794
			// (set) Token: 0x06003684 RID: 13956 RVA: 0x0001C0F7 File Offset: 0x0001A2F7
			public unsafe int _originalFrameRate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr__originalFrameRate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr__originalFrameRate_5__2)) = value;
				}
			}

			// Token: 0x17001002 RID: 4098
			// (get) Token: 0x06003685 RID: 13957 RVA: 0x000CB5BC File Offset: 0x000C97BC
			// (set) Token: 0x06003686 RID: 13958 RVA: 0x0001C112 File Offset: 0x0001A312
			public unsafe float _originalFixedDeltaTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr__originalFixedDeltaTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastForwardGameQueueCommand._execute_d__0.NativeFieldInfoPtr__originalFixedDeltaTime_5__3)) = value;
				}
			}

			// Token: 0x04002183 RID: 8579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002184 RID: 8580
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002185 RID: 8581
			private static readonly IntPtr NativeFieldInfoPtr__originalFrameRate_5__2;

			// Token: 0x04002186 RID: 8582
			private static readonly IntPtr NativeFieldInfoPtr__originalFixedDeltaTime_5__3;

			// Token: 0x04002187 RID: 8583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002188 RID: 8584
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002189 RID: 8585
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400218A RID: 8586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400218B RID: 8587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400218C RID: 8588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
