using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x02000459 RID: 1113
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x06004116 RID: 16662 RVA: 0x001383B4 File Offset: 0x001365B4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalBuilder()
		{
			Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "LocalBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr);
			LocalBuilder.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "name");
			LocalBuilder.NativeFieldInfoPtr_ilgen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "ilgen");
			LocalBuilder.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "startOffset");
			LocalBuilder.NativeFieldInfoPtr_endOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "endOffset");
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00017830 File Offset: 0x00015A30
		public LocalBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x00138434 File Offset: 0x00136634
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x00017839 File Offset: 0x00015A39
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x0013845C File Offset: 0x0013665C
		// (set) Token: 0x0600411B RID: 16667 RVA: 0x00017858 File Offset: 0x00015A58
		public unsafe ILGenerator ilgen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_ilgen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_ilgen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x0013848C File Offset: 0x0013668C
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x00017877 File Offset: 0x00015A77
		public unsafe int startOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_startOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_startOffset)) = value;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x001384B4 File Offset: 0x001366B4
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x00017892 File Offset: 0x00015A92
		public unsafe int endOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_endOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_endOffset)) = value;
			}
		}

		// Token: 0x0400359A RID: 13722
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400359B RID: 13723
		private static readonly IntPtr NativeFieldInfoPtr_ilgen;

		// Token: 0x0400359C RID: 13724
		private static readonly IntPtr NativeFieldInfoPtr_startOffset;

		// Token: 0x0400359D RID: 13725
		private static readonly IntPtr NativeFieldInfoPtr_endOffset;
	}
}
