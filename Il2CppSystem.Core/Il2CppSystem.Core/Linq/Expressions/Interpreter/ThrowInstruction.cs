using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000AC RID: 172
	public sealed class ThrowInstruction : Instruction
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x0003848C File Offset: 0x0003668C
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowInstruction()
		{
			Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ThrowInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr);
			ThrowInstruction.NativeFieldInfoPtr_Throw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, "Throw");
			ThrowInstruction.NativeFieldInfoPtr_VoidThrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, "VoidThrow");
			ThrowInstruction.NativeFieldInfoPtr_Rethrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, "Rethrow");
			ThrowInstruction.NativeFieldInfoPtr_VoidRethrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, "VoidRethrow");
			ThrowInstruction.NativeFieldInfoPtr__hasResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, "_hasResult");
			ThrowInstruction.NativeFieldInfoPtr__rethrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, "_rethrow");
			ThrowInstruction.NativeMethodInfoPtr__ctor_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, 100665011);
			ThrowInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, 100665012);
			ThrowInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, 100665013);
			ThrowInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, 100665014);
			ThrowInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, 100665015);
			ThrowInstruction.NativeMethodInfoPtr_WrapThrownObject_Private_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr, 100665016);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000385AC File Offset: 0x000367AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016232, XrefRangeEnd = 1016233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThrowInstruction(bool hasResult, bool isRethrow)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrowInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRethrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowInstruction.NativeMethodInfoPtr__ctor_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00038604 File Offset: 0x00036804
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016233, XrefRangeEnd = 1016235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0003863C File Offset: 0x0003683C
		public unsafe override int ProducedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00038678 File Offset: 0x00036878
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000386B4 File Offset: 0x000368B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016235, XrefRangeEnd = 1016253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00038704 File Offset: 0x00036904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016253, XrefRangeEnd = 1016255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception WrapThrownObject(Object thrown)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thrown);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowInstruction.NativeMethodInfoPtr_WrapThrownObject_Private_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000046A8 File Offset: 0x000028A8
		public ThrowInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00038748 File Offset: 0x00036948
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x000046B1 File Offset: 0x000028B1
		public unsafe static ThrowInstruction Throw
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThrowInstruction.NativeFieldInfoPtr_Throw, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThrowInstruction.NativeFieldInfoPtr_Throw, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00038770 File Offset: 0x00036970
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x000046C3 File Offset: 0x000028C3
		public unsafe static ThrowInstruction VoidThrow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThrowInstruction.NativeFieldInfoPtr_VoidThrow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThrowInstruction.NativeFieldInfoPtr_VoidThrow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00038798 File Offset: 0x00036998
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x000046D5 File Offset: 0x000028D5
		public unsafe static ThrowInstruction Rethrow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThrowInstruction.NativeFieldInfoPtr_Rethrow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThrowInstruction.NativeFieldInfoPtr_Rethrow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x000387C0 File Offset: 0x000369C0
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x000046E7 File Offset: 0x000028E7
		public unsafe static ThrowInstruction VoidRethrow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThrowInstruction.NativeFieldInfoPtr_VoidRethrow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThrowInstruction.NativeFieldInfoPtr_VoidRethrow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x000387E8 File Offset: 0x000369E8
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x000046F9 File Offset: 0x000028F9
		public unsafe bool _hasResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowInstruction.NativeFieldInfoPtr__hasResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowInstruction.NativeFieldInfoPtr__hasResult)) = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00038810 File Offset: 0x00036A10
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00004714 File Offset: 0x00002914
		public unsafe bool _rethrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowInstruction.NativeFieldInfoPtr__rethrow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowInstruction.NativeFieldInfoPtr__rethrow)) = value;
			}
		}

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_Throw;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr_VoidThrow;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_Rethrow;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_VoidRethrow;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr__hasResult;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr__rethrow;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_WrapThrownObject_Private_Static_Exception_Object_0;
	}
}
