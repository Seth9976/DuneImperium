using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lib.canis.src.input.context
{
	// Token: 0x02000011 RID: 17
	public class RegisterTransformWithInputContext : MonoBehaviour
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000089D8 File Offset: 0x00006BD8
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterTransformWithInputContext()
		{
			Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.canis.src.input.context", "RegisterTransformWithInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr);
			RegisterTransformWithInputContext.NativeFieldInfoPtr_inputContextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, "inputContextID");
			RegisterTransformWithInputContext.NativeFieldInfoPtr_registerOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, "registerOnStart");
			RegisterTransformWithInputContext.NativeFieldInfoPtr_inputContextRegistrar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, "inputContextRegistrar");
			RegisterTransformWithInputContext.NativeMethodInfoPtr_Start_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, 100663358);
			RegisterTransformWithInputContext.NativeMethodInfoPtr_Event_Register_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, 100663359);
			RegisterTransformWithInputContext.NativeMethodInfoPtr_Event_Deregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, 100663360);
			RegisterTransformWithInputContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, 100663361);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008A94 File Offset: 0x00006C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119262, XrefRangeEnd = 1119267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext.NativeMethodInfoPtr_Start_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008AD4 File Offset: 0x00006CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119267, XrefRangeEnd = 1119283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext.NativeMethodInfoPtr_Event_Register_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008B08 File Offset: 0x00006D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119283, XrefRangeEnd = 1119304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Deregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext.NativeMethodInfoPtr_Event_Deregister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008B3C File Offset: 0x00006D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119304, XrefRangeEnd = 1119308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterTransformWithInputContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000022C5 File Offset: 0x000004C5
		public RegisterTransformWithInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00008B78 File Offset: 0x00006D78
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000022CE File Offset: 0x000004CE
		public unsafe string inputContextID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext.NativeFieldInfoPtr_inputContextID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext.NativeFieldInfoPtr_inputContextID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00008BA0 File Offset: 0x00006DA0
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000022ED File Offset: 0x000004ED
		public unsafe bool registerOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext.NativeFieldInfoPtr_registerOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext.NativeFieldInfoPtr_registerOnStart)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00008BC8 File Offset: 0x00006DC8
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002308 File Offset: 0x00000508
		public unsafe MultiHeirarchicalInputContextRegistrar inputContextRegistrar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext.NativeFieldInfoPtr_inputContextRegistrar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiHeirarchicalInputContextRegistrar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext.NativeFieldInfoPtr_inputContextRegistrar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_inputContextID;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_registerOnStart;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_inputContextRegistrar;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_IEnumerator_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Event_Register_Public_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Event_Deregister_Public_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B6 RID: 182
		[ObfuscatedName("lib.canis.src.input.context.RegisterTransformWithInputContext+<Start>d__3")]
		public sealed class _Start_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06000818 RID: 2072 RVA: 0x00021450 File Offset: 0x0001F650
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__3()
			{
				Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterTransformWithInputContext>.NativeClassPtr, "<Start>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr);
				RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, "<>1__state");
				RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, "<>2__current");
				RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, "<>4__this");
				RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, 100663362);
				RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, 100663363);
				RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, 100663364);
				RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, 100663365);
				RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, 100663366);
				RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr, 100663367);
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x00021530 File Offset: 0x0001F730
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterTransformWithInputContext._Start_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x00021578 File Offset: 0x0001F778
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x000215AC File Offset: 0x0001F7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119249, XrefRangeEnd = 1119257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x0600081C RID: 2076 RVA: 0x000215E8 File Offset: 0x0001F7E8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x00021628 File Offset: 0x0001F828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119257, XrefRangeEnd = 1119262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x0600081E RID: 2078 RVA: 0x0002165C File Offset: 0x0001F85C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterTransformWithInputContext._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x000063F6 File Offset: 0x000045F6
			public _Start_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x06000820 RID: 2080 RVA: 0x0002169C File Offset: 0x0001F89C
			// (set) Token: 0x06000821 RID: 2081 RVA: 0x000063FF File Offset: 0x000045FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x06000822 RID: 2082 RVA: 0x000216C4 File Offset: 0x0001F8C4
			// (set) Token: 0x06000823 RID: 2083 RVA: 0x0000641A File Offset: 0x0000461A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x06000824 RID: 2084 RVA: 0x000216F4 File Offset: 0x0001F8F4
			// (set) Token: 0x06000825 RID: 2085 RVA: 0x00006439 File Offset: 0x00004639
			public unsafe RegisterTransformWithInputContext __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterTransformWithInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterTransformWithInputContext._Start_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004FC RID: 1276
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040004FD RID: 1277
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040004FE RID: 1278
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040004FF RID: 1279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000500 RID: 1280
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000501 RID: 1281
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000502 RID: 1282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000503 RID: 1283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000504 RID: 1284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
