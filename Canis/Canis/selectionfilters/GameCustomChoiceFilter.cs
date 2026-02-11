using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.selectionfilters
{
	// Token: 0x02000059 RID: 89
	public class GameCustomChoiceFilter : SelectionMessageFilter
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x0002D7A0 File Offset: 0x0002B9A0
		// Note: this type is marked as 'beforefieldinit'.
		static GameCustomChoiceFilter()
		{
			Il2CppClassPointerStore<GameCustomChoiceFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "GameCustomChoiceFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCustomChoiceFilter>.NativeClassPtr);
			GameCustomChoiceFilter.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomChoiceFilter>.NativeClassPtr, "Selection");
			GameCustomChoiceFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomChoiceFilter>.NativeClassPtr, 100664353);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCustomChoiceFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCustomChoiceFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCustomChoiceFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000044A3 File Offset: 0x000026A3
		public GameCustomChoiceFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0002D834 File Offset: 0x0002BA34
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000044AC File Offset: 0x000026AC
		public unsafe int Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameCustomChoiceFilter.NativeFieldInfoPtr_Selection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameCustomChoiceFilter.NativeFieldInfoPtr_Selection)) = value;
			}
		}

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
