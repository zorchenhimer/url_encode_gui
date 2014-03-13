using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace url_encode_gui {
	class CharacterReplacements {
		private struct CharPairs {
			public char C;
			public string S;
		}

		List<CharPairs> pairs;

		public CharacterReplacements() {
			pairs = new List<CharPairs>();
		}

		public void AddReplacement(char Character, string Replacement) {
			CharPairs cp = new CharPairs();
			cp.C = Character;
			cp.S = Replacement;
		}

		public string GetReplacement(char Character) {
			foreach(CharPairs cp in pairs) {
				if(cp.C == Character)
					return cp.S;
			}
			return Character.ToString();
		}
	}
}
