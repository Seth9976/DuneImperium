using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.commands
{
	// Token: 0x02000026 RID: 38
	public class ExecuteParallel : Command
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000AD4C File Offset: 0x00008F4C
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteParallel()
		{
			Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "ExecuteParallel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr);
			ExecuteParallel.NativeFieldInfoPtr__commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, "_commands");
			ExecuteParallel.NativeFieldInfoPtr__staggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, "_staggerTime");
			ExecuteParallel.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, "commands");
			ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_Func_1_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, 100663729);
			ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, 100663730);
			ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, 100663731);
			ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, 100663732);
			ExecuteParallel.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, 100663733);
			ExecuteParallel.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, 100663734);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000AE30 File Offset: 0x00009030
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1207563, RefRangeEnd = 1207596, XrefRangeStart = 1207563, XrefRangeEnd = 1207596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteParallel(Func<IEnumerable<Command>> commands)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_Func_1_IEnumerable_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000AE7C File Offset: 0x0000907C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1209343, RefRangeEnd = 1209355, XrefRangeStart = 1209330, XrefRangeEnd = 1209343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteParallel(IEnumerable<Command> commands)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000AEC8 File Offset: 0x000090C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1209356, RefRangeEnd = 1209357, XrefRangeStart = 1209355, XrefRangeEnd = 1209356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteParallel([Optional] Il2CppReferenceArray<Command> commands)
		{
			if (commands == null)
			{
				commands = new Il2CppReferenceArray<Command>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000AF20 File Offset: 0x00009120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209357, XrefRangeEnd = 1209369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteParallel(IEnumerable<Command> commands, float staggerTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref staggerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000AF7C File Offset: 0x0000917C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209369, XrefRangeEnd = 1209374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExecuteParallel.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209374, XrefRangeEnd = 1209386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExecuteParallel.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000029B6 File Offset: 0x00000BB6
		public ExecuteParallel(params Command[] commands)
			: this(new Il2CppReferenceArray<Command>(commands))
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000029C4 File Offset: 0x00000BC4
		public ExecuteParallel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000B00C File Offset: 0x0000920C
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000029CD File Offset: 0x00000BCD
		public unsafe Func<IEnumerable<Command>> _commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.NativeFieldInfoPtr__commands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Command>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.NativeFieldInfoPtr__commands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000B03C File Offset: 0x0000923C
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000029EC File Offset: 0x00000BEC
		public unsafe float _staggerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.NativeFieldInfoPtr__staggerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.NativeFieldInfoPtr__staggerTime)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000B064 File Offset: 0x00009264
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002A07 File Offset: 0x00000C07
		public unsafe List<Command> commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.NativeFieldInfoPtr_commands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr__commands;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr__staggerTime;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_IEnumerable_1_Command_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Command_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_Single_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000088 RID: 136
		[ObfuscatedName("dwd.core.commands.ExecuteParallel+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060004EC RID: 1260 RVA: 0x000164D0 File Offset: 0x000146D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass4_0>.NativeClassPtr);
				ExecuteParallel.__c__DisplayClass4_0.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass4_0>.NativeClassPtr, "commands");
				ExecuteParallel.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass4_0>.NativeClassPtr, 100663735);
				ExecuteParallel.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass4_0>.NativeClassPtr, 100663736);
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x00016538 File Offset: 0x00014738
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x00016574 File Offset: 0x00014774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209295, XrefRangeEnd = 1209301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Command> __ctor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr3) : null;
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x00004256 File Offset: 0x00002456
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x000165B4 File Offset: 0x000147B4
			// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0000425F File Offset: 0x0000245F
			public unsafe IEnumerable<Command> commands
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.__c__DisplayClass4_0.NativeFieldInfoPtr_commands);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.__c__DisplayClass4_0.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeFieldInfoPtr_commands;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Command_0;
		}

		// Token: 0x02000089 RID: 137
		[ObfuscatedName("dwd.core.commands.ExecuteParallel+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060004F2 RID: 1266 RVA: 0x000165E4 File Offset: 0x000147E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass6_0>.NativeClassPtr);
				ExecuteParallel.__c__DisplayClass6_0.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass6_0>.NativeClassPtr, "commands");
				ExecuteParallel.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass6_0>.NativeClassPtr, 100663737);
				ExecuteParallel.__c__DisplayClass6_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass6_0>.NativeClassPtr, 100663738);
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0001664C File Offset: 0x0001484C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x00016688 File Offset: 0x00014888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209301, XrefRangeEnd = 1209307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Command> __ctor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel.__c__DisplayClass6_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr3) : null;
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x0000427E File Offset: 0x0000247E
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000166C8 File Offset: 0x000148C8
			// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004287 File Offset: 0x00002487
			public unsafe IEnumerable<Command> commands
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.__c__DisplayClass6_0.NativeFieldInfoPtr_commands);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel.__c__DisplayClass6_0.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeFieldInfoPtr_commands;

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Command_0;
		}

		// Token: 0x0200008A RID: 138
		[ObfuscatedName("dwd.core.commands.ExecuteParallel+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x060004F8 RID: 1272 RVA: 0x000166F8 File Offset: 0x000148F8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteParallel>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr);
				ExecuteParallel._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, "<>1__state");
				ExecuteParallel._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, "<>2__current");
				ExecuteParallel._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, "<>4__this");
				ExecuteParallel._execute_d__7.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, "<i>5__2");
				ExecuteParallel._execute_d__7.NativeFieldInfoPtr__counter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, "<counter>5__3");
				ExecuteParallel._execute_d__7.NativeFieldInfoPtr__command_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, "<command>5__4");
				ExecuteParallel._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, 100663739);
				ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, 100663740);
				ExecuteParallel._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, 100663741);
				ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, 100663742);
				ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, 100663743);
				ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr, 100663744);
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x00016814 File Offset: 0x00014A14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteParallel._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x0001685C File Offset: 0x00014A5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x00016890 File Offset: 0x00014A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209307, XrefRangeEnd = 1209325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060004FC RID: 1276 RVA: 0x000168CC File Offset: 0x00014ACC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x0001690C File Offset: 0x00014B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209325, XrefRangeEnd = 1209330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060004FE RID: 1278 RVA: 0x00016940 File Offset: 0x00014B40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteParallel._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x000042A6 File Offset: 0x000024A6
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x06000500 RID: 1280 RVA: 0x00016980 File Offset: 0x00014B80
			// (set) Token: 0x06000501 RID: 1281 RVA: 0x000042AF File Offset: 0x000024AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x06000502 RID: 1282 RVA: 0x000169A8 File Offset: 0x00014BA8
			// (set) Token: 0x06000503 RID: 1283 RVA: 0x000042CA File Offset: 0x000024CA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x06000504 RID: 1284 RVA: 0x000169D8 File Offset: 0x00014BD8
			// (set) Token: 0x06000505 RID: 1285 RVA: 0x000042E9 File Offset: 0x000024E9
			public unsafe ExecuteParallel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteParallel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x06000506 RID: 1286 RVA: 0x00016A08 File Offset: 0x00014C08
			// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004308 File Offset: 0x00002508
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x06000508 RID: 1288 RVA: 0x00016A30 File Offset: 0x00014C30
			// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004323 File Offset: 0x00002523
			public unsafe float _counter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr__counter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr__counter_5__3)) = value;
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x0600050A RID: 1290 RVA: 0x00016A58 File Offset: 0x00014C58
			// (set) Token: 0x0600050B RID: 1291 RVA: 0x0000433E File Offset: 0x0000253E
			public unsafe Command _command_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr__command_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteParallel._execute_d__7.NativeFieldInfoPtr__command_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeFieldInfoPtr__counter_5__3;

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeFieldInfoPtr__command_5__4;

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
