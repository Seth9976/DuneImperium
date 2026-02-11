using System;
using boardgames.match.tutorial;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lib.canis.match.tutorial
{
	// Token: 0x02000020 RID: 32
	public class SelectEntityWithLayerCallToAction : SelectEntityCallToAction
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00021698 File Offset: 0x0001F898
		// Note: this type is marked as 'beforefieldinit'.
		static SelectEntityWithLayerCallToAction()
		{
			Il2CppClassPointerStore<SelectEntityWithLayerCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.match.tutorial", "SelectEntityWithLayerCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectEntityWithLayerCallToAction>.NativeClassPtr);
			SelectEntityWithLayerCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityWithLayerCallToAction>.NativeClassPtr, 100663534);
			SelectEntityWithLayerCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEntityWithLayerCallToAction>.NativeClassPtr, 100663535);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000216F0 File Offset: 0x0001F8F0
		public unsafe override string Identifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497349, XrefRangeEnd = 497365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectEntityWithLayerCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00021734 File Offset: 0x0001F934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497365, XrefRangeEnd = 497366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectEntityWithLayerCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectEntityWithLayerCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEntityWithLayerCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002777 File Offset: 0x00000977
		public SelectEntityWithLayerCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
