using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000114 RID: 276
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x0006CF48 File Offset: 0x0006B148
		// Note: this type is marked as 'beforefieldinit'.
		static MultilineAttribute()
		{
			Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MultilineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr);
			MultilineAttribute.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, "lines");
			MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, 100666433);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0006CFA0 File Offset: 0x0006B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660173, XrefRangeEnd = 660174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultilineAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00008ECA File Offset: 0x000070CA
		public MultilineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0006CFDC File Offset: 0x0006B1DC
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x00008ED3 File Offset: 0x000070D3
		public unsafe int lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines)) = value;
			}
		}

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_lines;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
