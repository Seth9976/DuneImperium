using System;
using dwd.core.commands;
using dwd.core.match.data;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using worm.canis.data.enums;

namespace worm.match.commands
{
	// Token: 0x02000235 RID: 565
	public class WormShowImperiumRowFlow : Command
	{
		// Token: 0x06001885 RID: 6277 RVA: 0x000629A0 File Offset: 0x00060BA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowImperiumRowFlow()
		{
			Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormShowImperiumRowFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr);
			WormShowImperiumRowFlow.NativeFieldInfoPtr_DismissablePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr, "DismissablePrompt");
			WormShowImperiumRowFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr, 100666699);
			WormShowImperiumRowFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr, 100666700);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00062A0C File Offset: 0x00060C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718818, XrefRangeEnd = 718823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowImperiumRowFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00062A58 File Offset: 0x00060C58
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowImperiumRowFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000E809 File Offset: 0x0000CA09
		public WormShowImperiumRowFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00062A94 File Offset: 0x00060C94
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x0000E812 File Offset: 0x0000CA12
		public unsafe FlavoredDismissablePrompt DismissablePrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow.NativeFieldInfoPtr_DismissablePrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow.NativeFieldInfoPtr_DismissablePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeFieldInfoPtr_DismissablePrompt;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000406 RID: 1030
		[ObfuscatedName("worm.match.commands.WormShowImperiumRowFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002A3D RID: 10813 RVA: 0x00097FF0 File Offset: 0x000961F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr);
				WormShowImperiumRowFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr, "<>9");
				WormShowImperiumRowFlow.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr, "<>9__1_0");
				WormShowImperiumRowFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr, 100666702);
				WormShowImperiumRowFlow.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_String_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr, 100666703);
			}

			// Token: 0x06002A3E RID: 10814 RVA: 0x0009806C File Offset: 0x0009626C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowImperiumRowFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A3F RID: 10815 RVA: 0x000980A8 File Offset: 0x000962A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718796, XrefRangeEnd = 718799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__1_0(Set s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_String_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002A40 RID: 10816 RVA: 0x0001716D File Offset: 0x0001536D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000980EC File Offset: 0x000962EC
			// (set) Token: 0x06002A42 RID: 10818 RVA: 0x00017176 File Offset: 0x00015376
			public unsafe static WormShowImperiumRowFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShowImperiumRowFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRowFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShowImperiumRowFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF7 RID: 3063
			// (get) Token: 0x06002A43 RID: 10819 RVA: 0x00098114 File Offset: 0x00096314
			// (set) Token: 0x06002A44 RID: 10820 RVA: 0x00017188 File Offset: 0x00015388
			public unsafe static Func<Set, string> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShowImperiumRowFlow.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Set, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShowImperiumRowFlow.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400187F RID: 6271
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001880 RID: 6272
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001881 RID: 6273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001882 RID: 6274
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_0_Internal_String_Set_0;
		}

		// Token: 0x02000407 RID: 1031
		[ObfuscatedName("worm.match.commands.WormShowImperiumRowFlow+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06002A45 RID: 10821 RVA: 0x0009813C File Offset: 0x0009633C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowImperiumRowFlow>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr);
				WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, "<>1__state");
				WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, "<>2__current");
				WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, "<>4__this");
				WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, "<entitiesProvider>5__2");
				WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, 100666704);
				WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, 100666705);
				WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, 100666706);
				WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, 100666707);
				WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, 100666708);
				WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr, 100666709);
			}

			// Token: 0x06002A46 RID: 10822 RVA: 0x00098230 File Offset: 0x00096430
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowImperiumRowFlow._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A47 RID: 10823 RVA: 0x00098278 File Offset: 0x00096478
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A48 RID: 10824 RVA: 0x000982AC File Offset: 0x000964AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718799, XrefRangeEnd = 718813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000982E8 File Offset: 0x000964E8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A4A RID: 10826 RVA: 0x00098328 File Offset: 0x00096528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718813, XrefRangeEnd = 718818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x06002A4B RID: 10827 RVA: 0x0009835C File Offset: 0x0009655C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRowFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A4C RID: 10828 RVA: 0x0001719A File Offset: 0x0001539A
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF8 RID: 3064
			// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0009839C File Offset: 0x0009659C
			// (set) Token: 0x06002A4E RID: 10830 RVA: 0x000171A3 File Offset: 0x000153A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BF9 RID: 3065
			// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000983C4 File Offset: 0x000965C4
			// (set) Token: 0x06002A50 RID: 10832 RVA: 0x000171BE File Offset: 0x000153BE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000983F4 File Offset: 0x000965F4
			// (set) Token: 0x06002A52 RID: 10834 RVA: 0x000171DD File Offset: 0x000153DD
			public unsafe WormShowImperiumRowFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRowFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x06002A53 RID: 10835 RVA: 0x00098424 File Offset: 0x00096624
			// (set) Token: 0x06002A54 RID: 10836 RVA: 0x000171FC File Offset: 0x000153FC
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRowFlow._execute_d__1.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001883 RID: 6275
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001884 RID: 6276
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001885 RID: 6277
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001886 RID: 6278
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001887 RID: 6279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001888 RID: 6280
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001889 RID: 6281
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400188A RID: 6282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400188B RID: 6283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400188C RID: 6284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
