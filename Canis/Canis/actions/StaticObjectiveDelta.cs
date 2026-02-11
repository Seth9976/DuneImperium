using System;
using Canis.context;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.actions
{
	// Token: 0x020001B8 RID: 440
	public class StaticObjectiveDelta : ObjectiveDeltaFactory
	{
		// Token: 0x060012AE RID: 4782 RVA: 0x000650DC File Offset: 0x000632DC
		// Note: this type is marked as 'beforefieldinit'.
		static StaticObjectiveDelta()
		{
			Il2CppClassPointerStore<StaticObjectiveDelta>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "StaticObjectiveDelta");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticObjectiveDelta>.NativeClassPtr);
			StaticObjectiveDelta.NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObjectiveDelta>.NativeClassPtr, "Delta");
			StaticObjectiveDelta.NativeMethodInfoPtr_MakeDelta_Public_Virtual_Int32_Objective_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticObjectiveDelta>.NativeClassPtr, 100667298);
			StaticObjectiveDelta.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticObjectiveDelta>.NativeClassPtr, 100667299);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00065148 File Offset: 0x00063348
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int MakeDelta(Objective objective, Context context, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objective);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticObjectiveDelta.NativeMethodInfoPtr_MakeDelta_Public_Virtual_Int32_Objective_Context_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000651C4 File Offset: 0x000633C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticObjectiveDelta()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticObjectiveDelta>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticObjectiveDelta.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000092A2 File Offset: 0x000074A2
		public StaticObjectiveDelta(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00065200 File Offset: 0x00063400
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x000092AB File Offset: 0x000074AB
		public unsafe int Delta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticObjectiveDelta.NativeFieldInfoPtr_Delta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticObjectiveDelta.NativeFieldInfoPtr_Delta)) = value;
			}
		}

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeFieldInfoPtr_Delta;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_MakeDelta_Public_Virtual_Int32_Objective_Context_Match_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
