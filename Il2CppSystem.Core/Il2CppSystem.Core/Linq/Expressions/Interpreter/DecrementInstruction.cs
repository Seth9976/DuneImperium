using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000AF RID: 175
	public class DecrementInstruction : Instruction
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00038C74 File Offset: 0x00036E74
		// Note: this type is marked as 'beforefieldinit'.
		static DecrementInstruction()
		{
			Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "DecrementInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr);
			DecrementInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_Int16");
			DecrementInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_Int32");
			DecrementInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_Int64");
			DecrementInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_UInt16");
			DecrementInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_UInt32");
			DecrementInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_UInt64");
			DecrementInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_Single");
			DecrementInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "s_Double");
			DecrementInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, 100665026);
			DecrementInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, 100665027);
			DecrementInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, 100665028);
			DecrementInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, 100665029);
			DecrementInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, 100665030);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00038DA8 File Offset: 0x00036FA8
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecrementInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00038DF0 File Offset: 0x00036FF0
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecrementInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00038E38 File Offset: 0x00037038
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016324, XrefRangeEnd = 1016326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecrementInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00038E7C File Offset: 0x0003707C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecrementInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00038EB8 File Offset: 0x000370B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1016350, RefRangeEnd = 1016352, XrefRangeStart = 1016326, XrefRangeEnd = 1016350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0000479E File Offset: 0x0000299E
		public DecrementInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00038EFC File Offset: 0x000370FC
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x000047A7 File Offset: 0x000029A7
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00038F24 File Offset: 0x00037124
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x000047B9 File Offset: 0x000029B9
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00038F4C File Offset: 0x0003714C
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000047CB File Offset: 0x000029CB
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00038F74 File Offset: 0x00037174
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000047DD File Offset: 0x000029DD
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00038F9C File Offset: 0x0003719C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x000047EF File Offset: 0x000029EF
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00038FC4 File Offset: 0x000371C4
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00004801 File Offset: 0x00002A01
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00038FEC File Offset: 0x000371EC
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00004813 File Offset: 0x00002A13
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00039014 File Offset: 0x00037214
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00004825 File Offset: 0x00002A25
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecrementInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecrementInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020001FE RID: 510
		public sealed class DecrementInt16 : DecrementInstruction
		{
			// Token: 0x060016C8 RID: 5832 RVA: 0x0006F2EC File Offset: 0x0006D4EC
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementInt16()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementInt16>.NativeClassPtr);
				DecrementInstruction.DecrementInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementInt16>.NativeClassPtr, 100665031);
				DecrementInstruction.DecrementInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementInt16>.NativeClassPtr, 100665032);
			}

			// Token: 0x060016C9 RID: 5833 RVA: 0x0006F340 File Offset: 0x0006D540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016269, XrefRangeEnd = 1016274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016CA RID: 5834 RVA: 0x0006F390 File Offset: 0x0006D590
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016CB RID: 5835 RVA: 0x0000992E File Offset: 0x00007B2E
			public DecrementInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FF5 RID: 4085
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FF6 RID: 4086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FF RID: 511
		public sealed class DecrementInt32 : DecrementInstruction
		{
			// Token: 0x060016CC RID: 5836 RVA: 0x0006F3CC File Offset: 0x0006D5CC
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementInt32()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementInt32>.NativeClassPtr);
				DecrementInstruction.DecrementInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementInt32>.NativeClassPtr, 100665033);
				DecrementInstruction.DecrementInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementInt32>.NativeClassPtr, 100665034);
			}

			// Token: 0x060016CD RID: 5837 RVA: 0x0006F420 File Offset: 0x0006D620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016274, XrefRangeEnd = 1016279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016CE RID: 5838 RVA: 0x0006F470 File Offset: 0x0006D670
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016CF RID: 5839 RVA: 0x00009937 File Offset: 0x00007B37
			public DecrementInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FF7 RID: 4087
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FF8 RID: 4088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000200 RID: 512
		public sealed class DecrementInt64 : DecrementInstruction
		{
			// Token: 0x060016D0 RID: 5840 RVA: 0x0006F4AC File Offset: 0x0006D6AC
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementInt64()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementInt64>.NativeClassPtr);
				DecrementInstruction.DecrementInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementInt64>.NativeClassPtr, 100665035);
				DecrementInstruction.DecrementInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementInt64>.NativeClassPtr, 100665036);
			}

			// Token: 0x060016D1 RID: 5841 RVA: 0x0006F500 File Offset: 0x0006D700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016279, XrefRangeEnd = 1016287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x0006F550 File Offset: 0x0006D750
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D3 RID: 5843 RVA: 0x00009940 File Offset: 0x00007B40
			public DecrementInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FF9 RID: 4089
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FFA RID: 4090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000201 RID: 513
		public sealed class DecrementUInt16 : DecrementInstruction
		{
			// Token: 0x060016D4 RID: 5844 RVA: 0x0006F58C File Offset: 0x0006D78C
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementUInt16()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt16>.NativeClassPtr);
				DecrementInstruction.DecrementUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt16>.NativeClassPtr, 100665037);
				DecrementInstruction.DecrementUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt16>.NativeClassPtr, 100665038);
			}

			// Token: 0x060016D5 RID: 5845 RVA: 0x0006F5E0 File Offset: 0x0006D7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016287, XrefRangeEnd = 1016292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016D6 RID: 5846 RVA: 0x0006F630 File Offset: 0x0006D830
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D7 RID: 5847 RVA: 0x00009949 File Offset: 0x00007B49
			public DecrementUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FFB RID: 4091
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FFC RID: 4092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000202 RID: 514
		public sealed class DecrementUInt32 : DecrementInstruction
		{
			// Token: 0x060016D8 RID: 5848 RVA: 0x0006F66C File Offset: 0x0006D86C
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementUInt32()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt32>.NativeClassPtr);
				DecrementInstruction.DecrementUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt32>.NativeClassPtr, 100665039);
				DecrementInstruction.DecrementUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt32>.NativeClassPtr, 100665040);
			}

			// Token: 0x060016D9 RID: 5849 RVA: 0x0006F6C0 File Offset: 0x0006D8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016292, XrefRangeEnd = 1016300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016DA RID: 5850 RVA: 0x0006F710 File Offset: 0x0006D910
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016DB RID: 5851 RVA: 0x00009952 File Offset: 0x00007B52
			public DecrementUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FFD RID: 4093
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FFE RID: 4094
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000203 RID: 515
		public sealed class DecrementUInt64 : DecrementInstruction
		{
			// Token: 0x060016DC RID: 5852 RVA: 0x0006F74C File Offset: 0x0006D94C
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementUInt64()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt64>.NativeClassPtr);
				DecrementInstruction.DecrementUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt64>.NativeClassPtr, 100665041);
				DecrementInstruction.DecrementUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt64>.NativeClassPtr, 100665042);
			}

			// Token: 0x060016DD RID: 5853 RVA: 0x0006F7A0 File Offset: 0x0006D9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016300, XrefRangeEnd = 1016308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016DE RID: 5854 RVA: 0x0006F7F0 File Offset: 0x0006D9F0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016DF RID: 5855 RVA: 0x0000995B File Offset: 0x00007B5B
			public DecrementUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FFF RID: 4095
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001000 RID: 4096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000204 RID: 516
		public sealed class DecrementSingle : DecrementInstruction
		{
			// Token: 0x060016E0 RID: 5856 RVA: 0x0006F82C File Offset: 0x0006DA2C
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementSingle()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementSingle>.NativeClassPtr);
				DecrementInstruction.DecrementSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementSingle>.NativeClassPtr, 100665043);
				DecrementInstruction.DecrementSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementSingle>.NativeClassPtr, 100665044);
			}

			// Token: 0x060016E1 RID: 5857 RVA: 0x0006F880 File Offset: 0x0006DA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016308, XrefRangeEnd = 1016316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016E2 RID: 5858 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016E3 RID: 5859 RVA: 0x00009964 File Offset: 0x00007B64
			public DecrementSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001001 RID: 4097
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001002 RID: 4098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000205 RID: 517
		public sealed class DecrementDouble : DecrementInstruction
		{
			// Token: 0x060016E4 RID: 5860 RVA: 0x0006F90C File Offset: 0x0006DB0C
			// Note: this type is marked as 'beforefieldinit'.
			static DecrementDouble()
			{
				Il2CppClassPointerStore<DecrementInstruction.DecrementDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecrementInstruction>.NativeClassPtr, "DecrementDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecrementInstruction.DecrementDouble>.NativeClassPtr);
				DecrementInstruction.DecrementDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementDouble>.NativeClassPtr, 100665045);
				DecrementInstruction.DecrementDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecrementInstruction.DecrementDouble>.NativeClassPtr, 100665046);
			}

			// Token: 0x060016E5 RID: 5861 RVA: 0x0006F960 File Offset: 0x0006DB60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016316, XrefRangeEnd = 1016324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016E6 RID: 5862 RVA: 0x0006F9B0 File Offset: 0x0006DBB0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecrementDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecrementInstruction.DecrementDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecrementInstruction.DecrementDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016E7 RID: 5863 RVA: 0x0000996D File Offset: 0x00007B6D
			public DecrementDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001003 RID: 4099
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001004 RID: 4100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
